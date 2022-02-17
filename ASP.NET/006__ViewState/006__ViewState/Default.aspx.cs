using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _006__ViewState
{
    public partial class Default : System.Web.UI.Page
    {
        public int counter
        {
            get
            {
                if (ViewState["pCounter"] != null)
                {
                    return (int)ViewState["pCounter"];
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                ViewState["pCounter"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            lblCounter.Text = counter.ToString();
            counter++;
        }

        protected void btnAddCount_Click(object sender, EventArgs e)
        {

        }
    }
}