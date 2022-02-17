using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseFinalProject_UserLoginSystem
{
    public partial class user_hub : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedInStatus"] != null)
            {
                if (Session["LoggedInStatus"].ToString().Trim() == "Y")
                {
                    DataTable dt = (DataTable)Session["UserDetails"];
                    lblFirstName.Text = dt.Rows[0]["FirstName"].ToString().Trim();
                    lblLastName.Text = dt.Rows[0]["LastName"].ToString().Trim();
                    lblFullName.Text = dt.Rows[0]["FullName"].ToString().Trim();
                    lblEmail.Text = dt.Rows[0]["Email"].ToString().Trim();

                    if (dt.Rows[0]["ActivationStatus"].ToString().Trim() == "Y")
                    {
                        lblStatus.CssClass = "text-success";
                        lblStatus.Text = "Active";
                    }
                    else
                    {
                        lblStatus.CssClass = "text-danger";
                        lblStatus.Text = "Deactive";
                    }

                    //only admin can see the user list
                    if (dt.Rows[0]["Email"].ToString().Trim()=="admin")
                    {
                        hyperLinkUserList.Visible = true;
                    }
                }
                else
                {
                    Response.Redirect("~/login.aspx");
                }
            }
            else
            {
                Response.Redirect("~/login.aspx");
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                Session["LoggedInStatus"] = null;
                Session["UserDetails"] = null;
                Response.Redirect("~/login.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("Faild to Logout.\n\n" + ex.Message.ToString());
            }
        }
    }
}