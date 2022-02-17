using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _003__ServerSide
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Access the HttpServerUtility methods through the intrinsic server object.
            lblShowResult.Text = "Welcome, " + Server.HtmlEncode(txtbxName.Text.Trim().ToString()) + ". <br /> And the URL is: " + Server.UrlEncode(Request.Url.ToString());
        }
    }
}