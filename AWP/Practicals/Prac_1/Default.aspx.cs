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

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        String enteredName = tbName.Text;
        Response.Write(enteredName);
        tbFavCar.Text = enteredName;

       int speed = tbTopSpeed.Text.Length;

       tbDGeneralDesc.Text = tbDGeneralDesc.Text + speed.ToString();
          
    }


    protected void btnSubmit_Reset(object sender, EventArgs e)
    {
        tbFavCar.Text = "";
        tbName.Text = "";
        tbTopSpeed.Text = "";

        foreach(ListItem item in rblCarEngine.Items){
            item.Selected = false;
        }

        tbSelectedEngine.Text = "";
        tbSelectedEngine.Visible = false;
    }

    protected void validateSpeed()
    {
        String speed = tbTopSpeed.Text;

        //if(speed.contains
    }


    protected void rblCarEngine_SelectedIndexChanged(object sender, EventArgs e)
    {
       
        tbSelectedEngine.Text = "";
        tbSelectedEngine.Visible = true;

        foreach (ListItem item in rblCarEngine.Items)
        {
            if (item.Selected)
            {
                tbSelectedEngine.Text += (item.Value+ "\n");
            }
        }

    }
    protected void cblFeatures_SelectedIndexChanged(object sender, EventArgs e)
    {
        tbOptionalExtras.Text = "";
        tbOptionalExtras.Visible = true;

        foreach (ListItem item in cblFeatures.Items)
        {
            if (item.Selected)
            {
                tbOptionalExtras.Text += (item.Value + "\n");
            }
        }
    }




    protected void rbReadTC_CheckedChanged(object sender, EventArgs e)
    {
       
    }
}
