using System;
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

    protected void uc1_FormSubmitted(object source, WebUserControl.FormsubmittedEventArgs e)
    {
        tbInfo.TextMode = System.Web.UI.WebControls.TextBoxMode.MultiLine;
        tbInfo.Text = "name is:" + e.name + "\nAge is:" + e.age;  
        //tbInfo.Text = "Info received";
    }
}