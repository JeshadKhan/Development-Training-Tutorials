using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseFinalProject_UserLoginSystem
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string msgSession = Session["Msg"].ToString().Trim();

            //if (msgSession != "")
            //{
            //    lblMsg.Text = msgSession;
            //}

            txtbxFirstName.Focus();
            lblWelcome.Text = "Please sign up. It's free.";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblWelcome.Visible = false;

            try
            {
                if (txtbxPassword.Text.ToString().Trim() == txtbxConfirmPassword.Text.ToString().Trim())
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

                    string email = txtbxEmail.Text.ToString().Trim();
                    DatabaseHandler db = new DatabaseHandler();

                    if (!db.CheckUserExistsByEmail(email))
                    {
                        DataModel model = new DataModel();
                        model.FirstName = txtbxFirstName.Text.ToString().Trim();
                        model.LastName = txtbxLastName.Text.ToString().Trim();
                        model.FullName = txtbxFirstName.Text.ToString().Trim() + " " + txtbxLastName.Text.ToString().Trim();
                        model.SecurityQuestion = txtbxSecurityQuestion.Text.ToString().Trim();
                        model.SecurityAnswer = txtbxSecurityAnswer.Text.ToString().Trim();
                        model.ActivationStatus = status;
                        model.Email = txtbxEmail.Text.ToString().Trim();
                        model.Password = txtbxPassword.Text.ToString().Trim();

                        if (db.CreateUser(model))
                        {
                            txtbxFirstName.Text = string.Empty;
                            txtbxLastName.Text = string.Empty;
                            txtbxSecurityQuestion.Text = string.Empty;
                            txtbxSecurityAnswer.Text = string.Empty;
                            chkbxActivationStatus.Checked = false;
                            txtbxEmail.Text = string.Empty;
                            txtbxPassword.Text = string.Empty;
                            txtbxConfirmPassword.Text = string.Empty;

                            lblMsg.CssClass = "text-success";
                            lblMsg.Text = "Create new user successfully.";

                            hyperLinkLogin.Visible = true;
                        }
                        else
                        {
                            lblMsg.Text = "Failed to create Account.";
                        }
                    }
                    else
                    {
                        lblMsg.Text = "Email exists. Try another email.";
                        txtbxEmail.Focus();
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
                lblMsg.Text = "Failed to create Account.\n\n" + ex.Message.ToString();
            }
        }
    }
}