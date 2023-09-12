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


    protected void calNew_SelectionChanged(object sender, EventArgs e)
    {
        tb_calDetails.Text = "";
        foreach (DateTime dt in calNew.SelectedDates)
        {
            tb_calDetails.Text += dt.ToString();
        }
    }


    protected void calNew_DayRender(object sender, DayRenderEventArgs e)
    {
        /*ArrayList vacations = new ArrayList();
        DateTime dt = new DateTime(0,8,18);
        vacations.Add(dt);

        foreach (DateTime vac in vacations)
        {
            

        }
         * */
        Dictionary<int, int> vacay_dates = new Dictionary<int, int>();
        vacay_dates.Add(26, 1); //republic day
        vacay_dates.Add(18, 2); //shiv ratri
        vacay_dates.Add(15, 8); //independence day
        vacay_dates.Add(19, 9); //ganesh chaturthi
        vacay_dates.Add(12, 11); //diwali
        vacay_dates.Add(25, 12);//christmas

        foreach(KeyValuePair<int,int> kvp in vacay_dates){
            
     
        if (e.Day.Date.Day == kvp.Key & e.Day.Date.Month == kvp.Value)
        {
            e.Cell.ForeColor =System.Drawing.Color.Red;
            Label lb = new Label();
            lb.Text = "<br/>Holiday";
           
            e.Cell.Controls.Add(lb);
        }
               }

    }
}