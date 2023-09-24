using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebUserControl : System.Web.UI.UserControl
{
    public class FormsubmittedEventArgs:EventArgs
    {
        public string name;
        public string age;


    }

    public event EventHandler<FormsubmittedEventArgs> FormSubmitted; //EventHandler is the delegate here

    //<FormsubmittedEventArgs> specifies the event arguments to be passed. It is an object of the specified class name
   
    protected void Page_Load(object sender, EventArgs e)
    {
        lblTime.Text = "Current time is:" + DateTime.Now.ToString();
    }

    protected void btndisplay_Click(object sender, EventArgs e)
    {
        FormsubmittedEventArgs args = new FormsubmittedEventArgs();
        args.name = tbName.Text;
        args.age = tbAge.Text;

        if (FormSubmitted != null)
        {
            //FormSubmitted(this,EventArgs.Empty); when the event declared doesnt have any arguments

            FormSubmitted(this, args); //raise event with argument
        }
    }
}