using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _002__EventHandling
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text += "Page load event handled. <br />";

            if (IsPostBack)
            {
                lblMessage.Text += "Post back event handled. <br />";
            }
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            lblMessage.Text += "Page Init event handled. <br />";
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            lblMessage.Text += "Page pre render event handled. <br />";
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            lblMessage.Text += "Button click event handled. <br />";
        }
    }
}