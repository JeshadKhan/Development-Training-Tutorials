using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _017__CustomControl
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCheckPalindrome_Click(object sender, EventArgs e)
        {
            this.customControl.Text = txtbxText.Text.Trim().ToString();
        }
    }
}