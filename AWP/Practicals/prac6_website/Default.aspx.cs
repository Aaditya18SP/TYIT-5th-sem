using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//these are newly added 
using System.Data.SqlClient;
using System.Data;
using System.Text; //for string builder
using System.Diagnostics; //for logging to the output console
using System.Collections; //for arraylist,list

public partial class _Default : System.Web.UI.Page
{
    //Create a connection to the database
    SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");


    //--------------------------------------------------EVENT HANDLERS-----------------------------------------------------------
    //1.Page load
    protected void Page_Load(object sender, EventArgs e)
    {

        
        /*----------------------------------------------------------------------------------------------------
        ERROR NOTE:-  
         If we dont check whether the page is posted back or loaded for the first time, then it causes null reference exception when the page is posted back after clicking on an item in listbox to view the specific details of the user.
         This exception is raised because when the page is posted back , the listbox items were being cleared. This also cleare their viewstate information. Hence when we click on the listbox item, the selected item property results to null, in the SelectedIndexChanged event handler of the listbox.
         ------------------------------------------------------------*/

        //Load the users only the first time the page is loaded
        if (!IsPostBack)
        {
            fetchUsersFromDB();

        }
     
        
    }

    //-------------------------------------------WHEN THE FETCH BUTTON IS CLICKED----------------------------------------
    protected void btnFetch_Click(object sender, EventArgs e)
    {
        fetchUsersFromDB();

    }


    //------------------------------------WHEN LISTBOX ITEMS ARE SELECTED------------------------------------
    protected void lboxAllDetails_SelectedIndexChanged(object sender, EventArgs e)
    {
       
            string selected_ctrl_id = lboxAllDetails.SelectedItem.Value.ToString();
            
            string fetchAllDetailsQuery = "select * from students where control_id = @ctrl_id";

            SqlCommand cmd = new SqlCommand(fetchAllDetailsQuery, conn);

            cmd.Parameters.AddWithValue("@ctrl_id", selected_ctrl_id);

            SqlDataReader reader;
            try
            {
                conn.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //-----DISPLAY DETAILS IN DIFFERENT TEXTBOXES-----
                    tbDispCtrlId.Text = reader["control_id"].ToString();
                    tbDispName.Text = reader["name"].ToString();
                    tbDispEmail.Text = reader["email"].ToString();
                    tbDispPhone.Text = reader["contactno"].ToString();
                    tbDispAddress.Text = reader["address"].ToString();

                    break; //to execute the query only once break out of the while loop
                }
                reader.Close();
            }
            catch (Exception err)
            {
                tbDisplayDetails.Text = "Error Occurred. It says:\n" + err.Message;
            }
            finally
            {
                conn.Close();
            }
        
       
    }


    //--------------------------WHEN EDIT BUTTON IS CLICKED--------------------
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        
        //tbDispCtrlId.Enabled = true; //do not allow editing the control_id
        tbDispName.Enabled = true;
        tbDispEmail.Enabled = true;
        tbDispPhone.Enabled = true;
        tbDispAddress.Enabled = true;

        btnSave.Visible = true;

        btnEdit.Visible = false;
    }

    //-------------------------WHEN THE SAVE BUTTON IS CLICKED---------------
    protected void btnSave_Click(object sender, EventArgs e)
    {
        //Toggle the buttons and input fields
        btnEdit.Visible = true;
        btnSave.Visible = false;

        //tbDispCtrlId.Enabled = false;
        tbDispName.Enabled = false;
        tbDispEmail.Enabled = false;
        tbDispPhone.Enabled = false;
        tbDispAddress.Enabled = false;


        /*--------------
         PERFORM UPDATE
         --------------*/

        int updated = 0;
        int selected_item_index = lboxAllDetails.SelectedIndex;
        Debug.WriteLine("The selected item index is: " + selected_item_index);

        //get the data from input fields 
        string ctrl_id = tbDispCtrlId.Text;
        string name = tbDispName.Text;
        string email = tbDispEmail.Text;
        string contactno = tbDispPhone.Text;
        string address= tbDispAddress.Text;
 
        string updateQuery = "update students set name=@name,email=@email,contactno=@contactno,address=@address where control_id=@ctrl_id";

        SqlCommand cmd = new SqlCommand(updateQuery, conn);

        cmd.Parameters.AddWithValue("@ctrl_id", ctrl_id);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@contactno", contactno);
        cmd.Parameters.AddWithValue("@address", address);

        try
        {
            conn.Open();
            updated = cmd.ExecuteNonQuery();

            if (updated > 0)
            {
                lbEditDeleteMsg.Text = "Updated successfully. Click on the user again to view the details";
                lbEditDeleteMsg.ForeColor = System.Drawing.Color.Green;

                tbDispCtrlId.Text = "";
                tbDispName.Text = "";
                tbDispPhone.Text = "";
                tbDispEmail.Text = "";
                tbDispAddress.Text = "";

                //fetchUsersFromDB();
            }
            
        }
        catch(Exception err)
        {
            lbEditDeleteMsg.Text = "Error while updating. It says: " + err.Message;
            lbEditDeleteMsg.ForeColor = System.Drawing.Color.Red;
        }
        finally
        {
            conn.Close();
        }


        if (updated > 0)
        {
            fetchUsersFromDB();

            //to display the details of the updated user. It selects the item in the listbox but doesnt fire the event related to it :(s
            //lboxAllDetails.SelectedIndex = selected_item_index;
        }


    }

    //--------------------WHEN DELETE BUTTON IS CLICKED-------------------
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        string ctrl_id = tbDispCtrlId.Text;
        int deleted=0;

        string deleteQuery = "delete from students where control_id=@ctrl_id";

        SqlCommand cmd = new SqlCommand(deleteQuery, conn);

        cmd.Parameters.AddWithValue("@ctrl_id", ctrl_id);

        try
        {
            conn.Open();
            deleted = cmd.ExecuteNonQuery();

            if(deleted > 0)
            {
                lbEditDeleteMsg.Text ="Deleted successfully";
                lbEditDeleteMsg.ForeColor = System.Drawing.Color.Green;
            }
        }
        catch(Exception err)
        {
            lbEditDeleteMsg.Text ="Error while deleting : " + err.Message;
            lbEditDeleteMsg.ForeColor = System.Drawing.Color.Red;
        }
        finally
        {
            conn.Close();
        }

        if(deleted > 0)
        {
            fetchUsersFromDB();
        }
        

    }

    //----------------------WHEN INSERT BUTTON IS CLICKED--------------------
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        int added=0;
        string ctrl_id = tbCtrlId.Text;
        string name = tbName.Text;
        string email = tbEmail.Text;
        string contactno = tbPhone.Text;
        string address = tbAddress.Text;

        string insertQuery = "insert into students(control_id,name,email,contactno,address) values(@ctrl_id,@name,@email,@contactno,@address)";
        SqlCommand cmd = new SqlCommand(insertQuery, conn);
        cmd.Parameters.AddWithValue("@ctrl_id",ctrl_id);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@contactno", contactno);
        cmd.Parameters.AddWithValue("@address", address);

       
        try
        {
            conn.Open();
             added = cmd.ExecuteNonQuery();
             if (added > 0)
             {
                 lbInsertMsg.Text = "<br/>Inserted successfully";
                 lbInsertMsg.ForeColor = System.Drawing.Color.Green;

                 //reset the input fields
                 tbCtrlId.Text = "";
                 tbName.Text = "";
                 tbPhone.Text = "";
                 tbEmail.Text = "";
                 tbAddress.Text = "";
             }
             
            
            /*
              ****Adding a Label programmatically****
             Label lbSuccessMessage = new Label();
             lbSuccessMessage.Text = "Added successfully";
             lbSuccessMessage.ForeColor = System.Drawing.Color.Green;

            //another way to add a label programmatically
             int index =form1.Controls.IndexOf(lbCtrlId);
             Debug.WriteLine("the index is:" + index);

             foreach (Control ctrl in form1.Controls)
             {
                 Debug.WriteLine("The controls are:" + ctrl.ID);
             }
             
             form1.Controls.AddAt(index - 1, lbSuccessMessage);
             
             */

        }
        catch (Exception err)
        {
            lbInsertMsg.Text = "<br/> Some Error Occurred: " + err.Message;
            lbInsertMsg.ForeColor = System.Drawing.Color.Red;
           
            /*
             ****Adding a Label programmatically****
            Label lbErrMessage = new Label();
            lbErrMessage.Text = "<br/> Some Error Occurred: " + err.Message;
            lbErrMessage.ForeColor = System.Drawing.Color.Red;
            //input_user_details.Controls.Add(lbErrMessage); //the div needs to be have the 'runat' attribute set to 'server'
             */
        }
        finally
        {
           
            conn.Close();
        }

        
        //fetch the users again. CHECK THIS. CURRENTLY AN ASSUMPTION:This is done because the insert operation is async. hence the fetching is done outside the 'finally' block.
        if (added > 0)
        {
            fetchUsersFromDB();
        }


    }

    //--------------------------------------------------------------------------CUSTOM FUNCTIONS------------------------------------------------------

    //1. Fetch the users from the database
    protected void fetchUsersFromDB()
    {
        lboxAllDetails.Items.Clear();
        ArrayList users = new ArrayList();
        string fetchCtrlIDQuery = "select * from students";

        SqlCommand cmd = new SqlCommand(fetchCtrlIDQuery, conn);

        SqlDataReader reader;

        try
        {
            //open the connection first
            conn.Open();

            //use the sqlcommand object to execute the query and store in reader objet.
            reader = cmd.ExecuteReader();

            //-------------TWO WAYS TO ADD THE FETCHED DATA INTO LISTBOX------------------
            //1. creating the listitems
            /*
            while (reader.Read())
            {
                ListItem lt = new ListItem();
                lt.Value = reader["control_id"].ToString();
                lt.Text = reader["control_id"].ToString();

                lboxAllDetails.Items.Add(lt);

            }
            */

            //2. By using DataBinding
            while (reader.Read())
            {
                users.Add(reader["control_id"].ToString());
               
            }

            lboxAllDetails.DataSource = users;
            lboxAllDetails.DataBind();

            Debug.WriteLine("Data binding implemented");

            reader.Close();
        }
        catch (Exception err)
        {
            tbDisplayDetails.Text = "Error Occurred. It says: " + err.Message;
        }
        finally
        {
            conn.Close();
        }
    }

    
   
}