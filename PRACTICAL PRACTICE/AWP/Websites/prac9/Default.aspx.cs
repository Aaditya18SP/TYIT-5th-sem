using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
         string query="Select * from cars_db";
            SqlCommand cmd = new SqlCommand(query,conn);
            SqlDataAdapter adpater = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adpater.Fill(ds, "cars_db");

            gvDynamicCars.DataSource = ds;
            gvDynamicCars.DataBind();
     



    }

    protected void gvDynamicCars_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string updateQuery = "Update cars_db set brand=@brand, type=@type where model=@model";
        string brand="UPDATED";
        string model="GT3";
        string type = "updated_type";

        SqlCommand cmd = new SqlCommand(updateQuery, conn);

        cmd.Parameters.AddWithValue("@brand", brand);
        cmd.Parameters.AddWithValue("@model", model);
        cmd.Parameters.AddWithValue("type",type);


        try
        {
            conn.Open();
            var x=cmd.ExecuteNonQuery();

            if(x == 1){
                Debug.WriteLine("Updated successful");
            }
            else{
                Debug.WriteLine("Update failure");
            }

        }
        catch (Exception err)
        {
            Debug.WriteLine("Error is:{0}", err.Message);
        }
        finally
        {
            conn.Close();
        }

    }
}