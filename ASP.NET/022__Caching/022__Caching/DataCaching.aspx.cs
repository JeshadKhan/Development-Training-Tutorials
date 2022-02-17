using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _022__Caching
{
    public partial class DataCaching : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTime.Text = string.Format("Page posted at: {0}", DateTime.Now.ToLongTimeString());
        }
    }
}