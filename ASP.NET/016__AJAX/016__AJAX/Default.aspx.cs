using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _016__AJAX
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToLongTimeString();
            lblPartial.Text = "Showing time from panel: " + time;
            lblTotal.Text = "Showing time from outside panel: " + time;
        }
    }
}