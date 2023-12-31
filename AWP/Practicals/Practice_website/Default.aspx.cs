﻿using System;
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
        //trigger the drop down list event when the page loads to display the items in the bulleted list initially when user has not yet selected an item from the dropdown
        ddlCarBrands_SelectedIndexChanged(sender, e);
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
        lboxContributors.Items.Remove(lboxContributors.SelectedItem);
    }


    //10. Clear the entire list
    protected void btnClearList_Click(object sender, EventArgs e)
    {
        lboxContributors.Items.Clear();
    }

    //11. Count total number of items in list
    protected void btnCount_Click(object sender, EventArgs e)
    {
        lbCount.Text = lboxContributors.Items.Count.ToString();
    }


    //12. Select multiple items
    protected void lboxContributors_SelectedIndexChanged(object sender, EventArgs e)
    {

        //NOTE: list items that are selected are only selected and displayed, duplicate values are not displayed
        tbSelectedItem.Text = "";
        foreach (ListItem item in lboxContributors.Items)
        {
            if (item.Selected)
            {
                tbSelectedItem.Text += item.Text;
            }
        }
        
    }


    //13.DropDownList Listener
    protected void ddlCarBrands_SelectedIndexChanged(object sender, EventArgs e)
    {
        String[] pagani_cars = { "ZondaF", "Huarya BC" };
        String[] porsche_cars = { "GT3 RS", "GT3", "GT2", "GT2RS" };
        String[] koenigsegg_cars = { "CCXR", "Jesko" };
        String[] ferrari_cars = { "458 italia", "812 GTS", "F12 TDF" };
        String[] mclaren_cars = { "720s", "Senna", "765LT" };

        String selected_brand = ddlCarBrands.SelectedItem.Value.ToLower().Trim();
        //lbBulletedList.Text = selected_brand;
        blCarModels.Items.Clear();

        switch (selected_brand)
        {
            case "ferrari":
                loopThroughCarModels(ferrari_cars);
                break;
            case "mclaren":
                loopThroughCarModels(mclaren_cars);
                break;
            case "pagani":
                loopThroughCarModels(pagani_cars);
                break;
            case "koenigsegg":
                loopThroughCarModels(koenigsegg_cars);
                break;
            case "porsche":
                loopThroughCarModels(porsche_cars);
                break;
            default:
                blCarModels.Items.Add("No items");
                break;
        }

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


    //3. Loop through the items of the array of car models of each brand
    protected void loopThroughCarModels(String[] car_brand)
    {
        foreach (String car_models in car_brand)
        {
            blCarModels.Items.Add(car_models);
        }

        //to redirect them to ZondaF.aspx page
        foreach (ListItem items in blCarModels.Items)
        {
            items.Value = "ZondaF.aspx";
        }
    }



    protected void tbName_TextChanged(object sender, EventArgs e)
    {

    }
    
}
