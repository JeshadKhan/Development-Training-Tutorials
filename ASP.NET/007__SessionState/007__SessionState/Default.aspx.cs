using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _007__SessionState
{
    public partial class Default : System.Web.UI.Page
    {
        // custom string variable
        string str;

        protected void Page_Load(object sender, EventArgs e)
        {
            // insert string variable value to Submit String label
            this.lblSubmitString.Text = this.str;

            // insert session value to Session label
            this.lblSession.Text = (string)this.Session["str"];
        }

        protected void btnSubmitString_Click(object sender, EventArgs e)
        {
            // insert textbox value to string variable
            this.str = txtbxString.Text.Trim().ToString();

            // insert textbox value to session by session key "str"
            Session["str"] = txtbxString.Text.Trim().ToString();


            // insert string variable value to Submit String label
            this.lblSubmitString.Text = this.str;

            // insert session value to Session label
            this.lblSession.Text = (string)this.Session["str"];
        }
    }
}