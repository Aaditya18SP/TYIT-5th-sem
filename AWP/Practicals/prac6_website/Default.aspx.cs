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

public partial class _Default : System.Web.UI.Page
{
    //Create a connection to the database
    SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        //load the data into the listbox programmatically
        //SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");

        string fetchCtrlIDQuery = "select * from students";

        SqlCommand cmd = new SqlCommand(fetchCtrlIDQuery,conn);

        SqlDataReader reader;

        try
        {
            //open the connection first
            conn.Open(); 

            //use the sqlcommand object to execute the query and store in reader objet.
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListItem lt = new ListItem();
                lt.Value = reader["control_id"].ToString();
                lt.Text = reader["control_id"].ToString();

                lboxAllDetails.Items.Add(lt);
 
            }
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

    //-------------WHEN LISTBOX ITEMS ARE SELECTED------------------------------

    protected void lboxAllDetails_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selected_ctrl_id = lboxAllDetails.SelectedItem.Value.ToString();
       // tbDisplayDetails.Text = "here";
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
                //-------------------------DISPLAY DETAILS IN DIFFERENT TEXTBOXES--------------------------
                tbDispCtrlId.Text = reader["control_id"].ToString();
                tbDispName.Text = reader["name"].ToString();
                tbDispEmail.Text = reader["email"].ToString();
                tbDispPhone.Text = reader["contactno"].ToString();
                tbDispAddress.Text = reader["address"].ToString();


                //--------------------DISPLAY DETAILS IN A SINGLE TEXTBOX------------------------
               /* string final_output = "Control id:" + reader["control_id"].ToString() + "\n" +
                    "Name:" + reader["name"].ToString() + "\n" +
                    "Email:" + reader["email"].ToString() + "\n" +
                    "Contact no:" + reader["contactno"].ToString() + "\n" +
                    "Address:" + reader["address"].ToString() + "\n";
                */

                //tbDisplayDetails.Text = final_output;
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


    //---------------------------WHEN EDIT BUTTON IS CLICKED-------------
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        
        tbDispCtrlId.Enabled = true;
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
        btnEdit.Visible = true;
        btnSave.Visible = false;

        tbDispCtrlId.Enabled = false;
        tbDispName.Enabled = false;
        tbDispEmail.Enabled = false;
        tbDispPhone.Enabled = false;
        tbDispAddress.Enabled = false;


        /*--------------
         PERFORM UPDATE
         --------------*/



    }

    //--------------------WHEN DELETE BUTTON IS CLICKED-------------------
    protected void btnDelete_Click(object sender, EventArgs e)
    {

    }

    //----------------------WHEN INSERT BUTTON IS CLICKED--------------------
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        string ctrl_id = tbCtrlId.Text;
        string name = tbName.Text;
        string email = tbEmail.Text;
        string contactno = tbPhone.Text;
        string address = tbAddress.Text;

        string insertQuery = "insert into students";

    }
}