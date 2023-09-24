using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void cvalPassword_ServerValidate(object source, ServerValidateEventArgs args)
    {
        var entered_value = tbPassword.Text;
        lbForPassword.Text = entered_value.ToString();
        if (entered_value.Contains("a"))
        {
            args.IsValid = true;
        }
        else
        {
            args.IsValid = false;
        }


    }
}