using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class WebUserControl : System.Web.UI.UserControl
{
    public class student:EventArgs
    {
        public string name;

    }

    public event EventHandler<student> SubmitEvent;


    protected void Page_Load(object sender, EventArgs e)
    {
        lblName.Text = DateTime.Now.ToString();


    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {

        student s1 = new student();
        s1.name = tbName.Text;

        if (SubmitEvent != null)
        {
            SubmitEvent(this,s1);
        }



    }
}