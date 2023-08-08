using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //----------------------------------------------VARIABLES-----------------------------------------------------------
    bool read_TC = false;
    bool agreed_to_TC = false;


    //----------------------------------------------EVENT_LISTENERS-----------------------------------------------------------

    //1. When the page loads 
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //2. when the submit button is clicked
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        String enteredName = tbName.Text;
        Response.Write(enteredName);
        tbFavCar.Text = enteredName;

        int speed = tbTopSpeed.Text.Length;

        tbDGeneralDesc.Text = tbDGeneralDesc.Text + speed.ToString();

    }

    //3. When the reset button is clicked
    protected void btnSubmit_Reset(object sender, EventArgs e)
    {
        tbFavCar.Text = "";
        tbName.Text = "";
        tbTopSpeed.Text = "";

        foreach (ListItem item in rblCarEngine.Items)
        {
            item.Selected = false;
        }

        tbSelectedEngine.Text = "";
        tbSelectedEngine.Visible = false;
    }


   
//4. When an  item in the RadioButtonList  is selected ie from Car engines
    protected void rblCarEngine_SelectedIndexChanged(object sender, EventArgs e)
    {

        tbSelectedEngine.Text = "";
        tbSelectedEngine.Visible = true;

        foreach (ListItem item in rblCarEngine.Items)
        {
            if (item.Selected)
            {
                tbSelectedEngine.Text += (item.Value + "\n");
            }
        }

    }

    //5. When an  item in the CheckBoxList  is selected ie from Car features
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



    //6. When an  Read_TC radio button is toggled
    protected void rbReadTC_CheckedChanged(object sender, EventArgs e)
    {
        if (rbReadTC.Checked)
        {
            read_TC = true;
        }
        else
        {
            read_TC = false;
        }


        //enable disable the submit button
        //enableDisableSubmitBtn();

    }

    //6. When an  NotRead_TC radio button is toggled
    protected void rbNotReadTC_CheckedChanged(object sender, EventArgs e)
    {
        if (rbNotReadTC.Checked)
        {
            read_TC = false;
        }

        //enable disable the submit button
        //enableDisableSubmitBtn();
    }

    //7. When the AgreeTC Checkbox is checked
    protected void cbAgreeTC_CheckedChanged(object sender, EventArgs e)
    {
        if (cbAgreeTC.Checked)
        {
            agreed_to_TC = true;
        }
        else
        {
            agreed_to_TC = false;
        }

        //enable disable the submit button
        enableDisableSubmitBtn();
    }

    //8. Add a new contributor
    protected void btnAddContributor_Click(object sender, EventArgs e)
    {
        lboxContributors.Items.Add(tbAddNewContributor.Text);
    }


    //9. Remove the selected contributor
    protected void btnRemoveContributor_Click(object sender, EventArgs e)
    {

    }


    //10. Clear the entire list
    protected void btnClearList_Click(object sender, EventArgs e)
    {

    }

    //11. Count total number of items in list
    protected void btnCount_Click(object sender, EventArgs e)
    {

    }


    //12. Select multiple items
    protected void lboxContributors_SelectedIndexChanged(object sender, EventArgs e)
    {

    }



    //---------------------------------------CUSTOM FUNCTIONS----------------------------------------------------------------------
    //1. to enable disable the submit button based on whether the TC is agreed to and read

    protected void enableDisableSubmitBtn()
    {
        //get the selection again because autoPostBack resets the variables

        //radioButton
        if (rbReadTC.Checked)
        {
            read_TC = true;
        }

        //CheckBox
        if (cbAgreeTC.Checked)
        {
            agreed_to_TC = true;
        }

        //enable disable the submit button
        if (read_TC & agreed_to_TC)
        {
            btnSubmit.Enabled = true;
            btnSubmit.BackColor = System.Drawing.Color.Blue;
        }
        else
        {
            Response.Write(read_TC + " " +agreed_to_TC);

            tbDGeneralDesc.Text += ("\n" + read_TC + " " + agreed_to_TC);

            btnSubmit.Enabled = false;
            btnSubmit.BackColor = System.Drawing.Color.Gray;
        }
    }

    //2. validate the speed
    protected void validateSpeed()
    {
        String speed = tbTopSpeed.Text;

        //if(speed.contains
    }



   
}
