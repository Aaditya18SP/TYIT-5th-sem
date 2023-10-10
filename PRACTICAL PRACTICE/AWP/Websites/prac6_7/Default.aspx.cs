using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.Collections;


public partial class _Default : System.Web.UI.Page
{

    class Cars
    {
        public string brand{get;set;}
        public int id { get; set; }
        public string model { get; set; }
        public string type { get; set; }

    }
    SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fetchCars();

        }

    }

    protected void lboxCars_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id=Convert.ToInt32(lboxCars.SelectedItem.Value);
        string fetchQuery = "select * from cars_db where id=@id";

        SqlCommand cmd = new SqlCommand(fetchQuery, conn);

        cmd.Parameters.AddWithValue("@id", id);
        SqlDataReader reader;

        try
        {
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tbId.Text = reader["id"].ToString();
                TextBox1.Text = reader["brand"].ToString();
                TextBox2.Text = reader["model"].ToString();
                TextBox3.Text = reader["type"].ToString();

            }
        }
        catch(Exception err){
            lblError.Text = "err" + err.Message;
        }
        finally
        {
            conn.Close();
        }

    }

    //------------------------------------FUNCTIONS-----------------

    protected void fetchCars()
    {
        
        string fetchquery = "select * from cars_db";

        SqlCommand cmd = new SqlCommand(fetchquery, conn);

        SqlDataReader reader;

        /*
         * BIND TO GRIDVIEW USING ADAPTER
        SqlDataAdapter adapter= new SqlDataAdapter();
        DataSet ds= new DataSet();
        adapter.Fill(ds,"cars_db");

        gvCars.DataSource=ds;
        gvCars.DataBind();
         */
        List<Cars> all_cars= new List<Cars>();

        try
        {
            conn.Open();

            reader= cmd.ExecuteReader();

            while (reader.Read())
            {
                Cars c1=new Cars();
                c1.id=(int) reader["id"];
                c1.brand=(string) reader["brand"];
                c1.model=(string) reader["model"];
                c1.type=(string) reader["type"];

                all_cars.Add(c1);

            }


            ArrayList ids = new ArrayList();
            foreach (Cars c1 in all_cars)
            {
                ids.Add(c1.id.ToString());
            }

            lboxCars.DataSource=ids;
            lboxCars.DataBind();

            gvCars.DataSource = all_cars;
            gvCars.DataBind();

            reader.Close();
            
        }
        catch (Exception e)
        {
            lblError.Text = "Error:" + e.Message;
        }
        finally
        {
            conn.Close();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string brand = TextBox1.Text;
        string model = TextBox2.Text;
        string type = TextBox3.Text;
        int id = Convert.ToInt32(tbId.Text);

        string query = "update cars_db set brand=@brand, model=@model,type=@type where id=@id";
        SqlCommand cmd = new SqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@brand", brand);
        cmd.Parameters.AddWithValue("@model", model);
        cmd.Parameters.AddWithValue("@type", type);
        var x=0;

        try
        {
            conn.Open();

             x = cmd.ExecuteNonQuery();

            if (x > 0)
            {

            }


        }
        catch (Exception err)
        {
            lblError.Text = "Error updating:" + err.Message;
        }
        finally
        {
            conn.Close();
        }

        if (x > 1)
        {
            fetchCars();
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(tbId.Text);
        string query = "delete from cars_db where id=@id";

        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@id", id);

        var y=0;

        try
        {
            conn.Open();
            y = cmd.ExecuteNonQuery();

        }
        catch (Exception err)
        {
            lblError.Text = "Error:" + err.Message;
        }
        finally
        {
            conn.Close();

        }

        if (y > 0)
        {
            fetchCars();
        }
    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(TextBox4.Text);
        string brand = TextBox5.Text;
        string model = TextBox6.Text;
        string type = TextBox7.Text;

        string query = "Insert into cars_db(id,brand,model,type) values(@id, @brand,@model,@type)";
        SqlCommand cmd = new SqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@brand", brand);
        cmd.Parameters.AddWithValue("@model", model);
        cmd.Parameters.AddWithValue("@type", type);
        var x = 0;

        try
        {
            conn.Open();
            x = cmd.ExecuteNonQuery();

        }
        catch (Exception err)
        {
            lblError.Text = "Error:" + err.Message;
        }
        finally
        {
            conn.Close();
        }

        if (x > 0)
        {
            fetchCars();
        }

    }
}