using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseFinalProject_UserLoginSystem
{
    public partial class edit_user_info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrEmpty(Session["LoggedInStatus"].ToString().Trim()))
                {
                    if (Session["LoggedInStatus"].ToString().Trim() == "Y")
                    {
                        DataTable dt = (DataTable)Session["UserDetails"];
                        hiddenFieldUserId.Value = dt.Rows[0]["UserID"].ToString().Trim();
                        txtbxFirstName.Text = dt.Rows[0]["FirstName"].ToString().Trim();
                        txtbxLastName.Text = dt.Rows[0]["LastName"].ToString().Trim();
                        txtbxSecurityQuestion.Text = dt.Rows[0]["SecurityQuestion"].ToString().Trim();
                        txtbxSecurityAnswer.Text = dt.Rows[0]["SecurityAnswer"].ToString().Trim();

                        if (dt.Rows[0]["ActivationStatus"].ToString().Trim() == "Y")
                        {
                            chkbxActivationStatus.Checked = true;
                        }
                        else
                        {
                            chkbxActivationStatus.Checked = false;
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
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                char status;

                if (chkbxActivationStatus.Checked)
                {
                    status = 'Y';
                }
                else
                {
                    status = 'N';
                }

                DatabaseHandler db = new DatabaseHandler();
                DataModel model = new DataModel();
                model.UserId = hiddenFieldUserId.Value.ToString().Trim();
                model.FirstName = txtbxFirstName.Text.ToString().Trim();
                model.LastName = txtbxLastName.Text.ToString().Trim();
                model.FullName = txtbxFirstName.Text.ToString().Trim() + " " + txtbxLastName.Text.ToString().Trim();
                model.SecurityQuestion = txtbxSecurityQuestion.Text.ToString().Trim();
                model.SecurityAnswer = txtbxSecurityAnswer.Text.ToString().Trim();
                model.ActivationStatus = status;

                DataTable dt = db.ChangeInfoById(model);
                Session["UserDetails"] = dt;

                if (dt.Rows.Count == 1)
                {
                    txtbxFirstName.Text = dt.Rows[0]["FirstName"].ToString().Trim();
                    txtbxLastName.Text = dt.Rows[0]["LastName"].ToString().Trim();
                    txtbxSecurityQuestion.Text = dt.Rows[0]["SecurityQuestion"].ToString().Trim();
                    txtbxSecurityAnswer.Text = dt.Rows[0]["SecurityAnswer"].ToString().Trim();

                    if (dt.Rows[0]["ActivationStatus"].ToString().Trim() == "Y")
                    {
                        chkbxActivationStatus.Checked = true;
                    }
                    else
                    {
                        chkbxActivationStatus.Checked = false;
                    }

                    txtbxFirstName.ReadOnly = true;
                    txtbxLastName.ReadOnly = true;
                    txtbxSecurityQuestion.ReadOnly = true;
                    txtbxSecurityAnswer.ReadOnly = true;
                    chkbxActivationStatus.Enabled = false;

                    lblMsg.CssClass = "text-success";
                    lblMsg.Text = "Information changed successfully.\n\nFor further change you need to re-enter this page.";
                }
                else
                {
                    lblMsg.Text = "Failed to change Information.";
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Failed to change Information.\n\n" + ex.Message.ToString();
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