using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseFinalProject_UserLoginSystem
{
    public partial class change_password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtbxPassword.Focus();

                if (!string.IsNullOrEmpty(Session["LoggedInStatus"].ToString().Trim()))
                {
                    if (Session["LoggedInStatus"].ToString().Trim() == "Y")
                    {
                        DataTable dt = (DataTable)Session["UserDetails"];
                        hiddenFieldUserId.Value = dt.Rows[0]["UserID"].ToString().Trim();
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
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                string password = txtbxPassword.Text.ToString().Trim();
                string confirmPassword = txtbxConfirmPassword.Text.ToString().Trim();
                string userId = hiddenFieldUserId.Value.ToString().Trim();

                if (password == confirmPassword)
                {
                    DatabaseHandler db = new DatabaseHandler();
                    if (db.ChangePasswordById(userId, password))
                    {
                        txtbxPassword.Text = string.Empty;
                        txtbxConfirmPassword.Text = string.Empty;

                        lblMsg.CssClass = "text-success";
                        lblMsg.Text = "Password changed successfully.";
                    }
                    else
                    {
                        lblMsg.Text = "Failed to change Password.";
                    }
                }
                else
                {
                    lblMsg.Text = "Password does not match.";
                    txtbxPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Failed to change Password.\n\n" + ex.Message.ToString();
            }
        }

        protected void btnDashboard_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("~/user-hub.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("Failed to Redirect.\n\n" + ex.Message.ToString());
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