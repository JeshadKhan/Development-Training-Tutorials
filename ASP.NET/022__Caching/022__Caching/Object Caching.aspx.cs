using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _022__Caching
{
    public partial class Object_Caching : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                lblInfo.Text += "Page Post Back.<br />";
            }
            else
            {
                lblInfo.Text += "Page Created.<br />";
            }

            if (Cache["testItem"] == null)
            {
                lblInfo.Text += "Creating test item.<br />Storing test item in cache for 30 seconds.<hr />";
                DateTime currentTime = DateTime.Now;
                Cache.Insert("testItem", currentTime, null, DateTime.Now.AddSeconds(30), TimeSpan.Zero);
            }
            else
            {
                DateTime cacheTime = (DateTime)Cache["testItem"];
                lblInfo.Text += "Retrieving test item.<br />Test item is: " + cacheTime.ToString() + "<hr />";
            }
        }
    }
}