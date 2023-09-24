using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void adVertical_AdCreated(object sender, AdCreatedEventArgs e)
    {
        tb_adDetails.Text = "Ad details: \n" + e.AdProperties["ImageUrl"].ToString()+ " \n "+
            e.AdProperties["NavigateUrl"].ToString() + "\n" + e.AdProperties["Keyword"].ToString() +"\n" + e.AdProperties["Impressions"].ToString() +"\n" ;
    }
}