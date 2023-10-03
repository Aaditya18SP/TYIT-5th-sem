using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
    
    protected void Page_Load(object sender, EventArgs e)
    {
        string selectquery="select * from students";
        SqlCommand cmd = new SqlCommand(selectquery,conn);
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adapter.Fill(ds, "students"); //2nd parameter is the name of the table

        gvStudentsDataBind.DataSource = ds;
        gvStudentsDataBind.DataBind();
    }

    //---------------SELECT EVENT--------------------------------
    protected void gvStudentsDataBind_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    //---------------EDIT EVENT--------------------------------
    protected void gvStudentsDataBind_RowEditing(object sender, GridViewEditEventArgs e)
    {
        string updatequery = "";
        SqlCommand cmd = new SqlCommand(updatequery,conn);

    }

    //---------------DELETE EVENT--------------------------------
    protected void gvStudentsDataBind_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {


    }

  
}