using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// this is the proxy.
// make it by adding service refference
using WebServices;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lblMessage.Text += "First Time Load at: " + DateTime.Now.ToLongTimeString();
        }
        else
        {
            lblMessage.Text += "<br />PostBack at: " + DateTime.Now.ToLongTimeString();
        }
    }
    protected void btnPostBack_Click(object sender, EventArgs e)
    {

    }
    protected void btnService_Click(object sender, EventArgs e)
    {
        StockService proxyStock = new StockService();
        lblMessage.Text += string.Format("<br />Current SATYAM Price: <b>{0}</b>", proxyStock.GetPrice("SATYAM").ToString());
    }
}