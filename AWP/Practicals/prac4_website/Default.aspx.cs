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
    protected void tbName_TextChanged(object sender, EventArgs e)
    {

    }
   
 
    protected void cvalPassword_ServerValidate(object source, ServerValidateEventArgs args)
    {
        string entered_password = tbPassword.Text;
        string reg_ex = "\\S+[a-zA-Z0-9][8]";
        Regex re = new Regex(reg_ex);
        if (re.IsMatch(entered_password))
        {
            cvalPassword.IsValid = true;
            lbForConfirmPassword.Text = "Valid Password";
        }
        else
        {
            cvalPassword.IsValid = true;
        }
    }
    
}