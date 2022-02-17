using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseFinalProject_UserLoginSystem
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblYear.Text = dt.Year.ToString().Trim();
            lblToday.Text = dt.ToLongDateString() + ".";
        }
    }
}