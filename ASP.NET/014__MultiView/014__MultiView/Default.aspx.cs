using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _014__MultiView
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void drpdwnlstChangeView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drpdwnlstChangeView.SelectedIndex == 1)
            {
                multiView.ActiveViewIndex = 1;
            }
            else if (drpdwnlstChangeView.SelectedIndex == 2)
            {
                multiView.ActiveViewIndex = 2;
            }
            else
            {
                multiView.ActiveViewIndex = 0;
            }
        }

        protected void multiView_ActiveViewChanged(object sender, EventArgs e)
        {
            if (multiView.ActiveViewIndex == 1)
            {
                drpdwnlstChangeView.SelectedIndex = 1;
            }
            else if (multiView.ActiveViewIndex == 2)
            {
                drpdwnlstChangeView.SelectedIndex = 2;
            }
            else
            {
                drpdwnlstChangeView.SelectedIndex = 0;
            }
        }
    }
}