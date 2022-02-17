using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _013__Calender
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calendar_SelectionChanged(object sender, EventArgs e)
        {
            lblToday.Text = "Today is: " + calendar.TodaysDate.ToShortDateString();
            lblBirthday.Text = "Birthday is: " + calendar.SelectedDate.ToShortDateString();
        }
    }
}