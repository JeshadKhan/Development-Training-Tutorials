using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace _022__Caching
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(10000);
            Response.Write("This page is generated and cache at: " + DateTime.Now.ToString());
        }

        protected void btnMagic_Click(object sender, EventArgs e)
        {
            Response.Write("<br /><br /><h2>Hello, " + txtbxName.Text.ToString().Trim() + "</h2>");
        }
    }
}