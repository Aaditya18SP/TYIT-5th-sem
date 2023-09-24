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
   
    protected void calNew_SelectionChanged(object sender, EventArgs e)
    {
        tb_calDetails.Text = "";
        tb_calDetails.TextMode = System.Web.UI.WebControls.TextBoxMode.MultiLine;

        //get the selected dats
        foreach (DateTime dt in calNew.SelectedDates)
        {
            tb_calDetails.Text += dt.ToString();

        }


        //difference between two dates
        DateTime selected_date = calNew.SelectedDate;
        DateTime current_date = DateTime.Now;
        var diff_dates = current_date.Subtract(selected_date); //the substraction returns an timespan object
        tb_calDetails.Text += "\nDifference between today and selected date in DAYS is:" + diff_dates.Days;
        tb_calDetails.Text += "\nDifference between today and selected date in HOURS  is:" + diff_dates.Hours;
        tb_calDetails.Text += "\nDifference between today and selected date in TOTAL_DAYS is:" + diff_dates.TotalDays;
    }


    protected void calNew_DayRender(object sender, DayRenderEventArgs e)
    {


        //Marking these days as holidays for every year
        ArrayList perma_holidays = new ArrayList();
        perma_holidays.Add("26/1/Republic Day");
        perma_holidays.Add("15/8/Independence Day");
        perma_holidays.Add("2/10/Gandhi Jayanti");
        perma_holidays.Add("25/12/Christmas");

        foreach (string date in perma_holidays)
        {
            char[] splitting_char = new char[1];
            splitting_char[0] = '/';
            string[] month = date.Split(splitting_char);

            if (e.Day.Date.Day == Convert.ToInt32(month[0]) & e.Day.Date.Month == Convert.ToInt32(month[1]))
            {
                e.Cell.BackColor = System.Drawing.Color.Red;

                Label lbHolidayName = new Label();
                lbHolidayName.Text = "<br/>" + month[2];
                e.Cell.Controls.Add(lbHolidayName);
            }
        }

        //Marking the following dates are holidays for this year
        Dictionary<string, string> holidays_this_year = new Dictionary<string, string>();
        holidays_this_year.Add("18/2/2023", "Shivratri");
        holidays_this_year.Add("19/9/2023", "Ganesh Chaturthi");
        holidays_this_year.Add("12/11/2023", "Diwali");

        foreach (KeyValuePair<string, string> current_holiday in holidays_this_year)
        {
            if (e.Day.Date.Equals(DateTime.Parse(current_holiday.Key)))
            {
                e.Cell.BackColor = System.Drawing.Color.SkyBlue;
                if (e.Day.Date.Equals(DateTime.Parse("19/09/2023")))
                {
                    //Ganesh chaturthi festival
                    DateTime ganesh_chaturthi_end_date = e.Day.Date.AddDays(5);
                    calNew.SelectedDates.SelectRange(e.Day.Date, ganesh_chaturthi_end_date);

                    Label lbHolidayName = new Label();
                    lbHolidayName.Text = "<br/>" + current_holiday.Value;
                    e.Cell.Controls.Add(lbHolidayName);

                }
            }
        }

    }
}