using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseFinalProject_UserLoginSystem
{
    public partial class forgot_pssword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmitEmail_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtbxEmail.Text.ToString().Trim();
                DatabaseHandler db = new DatabaseHandler();

                if (db.CheckUserExistsByEmail(email))
                {
                    SelectionRecoveryMethod(email);
                }
                else
                {
                    lblMsg.Text = "User does not exists.";
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Failed to find user.\n\n" + ex.Message.ToString();
            }
        }

        protected void SelectionRecoveryMethod(string email)
        {
            try
            {
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = new DataTable();
                DataModel model = new DataModel();

                if (rdibtnlstSelection.SelectedValue == "SC")
                {
                    dt = db.GetUserByEmail(email);
                    model.FullName = dt.Rows[0]["FullName"].ToString().Trim();
                    model.Email = dt.Rows[0]["Email"].ToString().Trim();

                    hiddenFieldEmail.Value = email.ToString();
                    hiddenFieldSecurityCode.Value = db.GenerateSecurityCode(model);

                    lblMsg.Attributes.Add("class", "text-success");
                    lblMsg.Text = "Security code is send to your email. Please check your email.";

                    divSelection.Visible = false;
                    divSecurityCode.Visible = true;
                    txtbxSecurityCode.Focus();
                }
                else if (rdibtnlstSelection.SelectedValue == "QA")
                {
                    dt = db.GetUserByEmail(email);
                    lblSecurityQuestion.Text = dt.Rows[0]["SecurityQuestion"].ToString().Trim();
                    hiddenFieldSecurityAnswer.Value = dt.Rows[0]["SecurityAnswer"].ToString().Trim();
                    hiddenFieldEmail.Value = email.ToString();

                    lblMsg.Attributes.Add("class", "text-success");
                    lblMsg.Text = "Answer the question below and submit.";

                    divSelection.Visible = false;
                    divQuestionAnswer.Visible = true;
                    txtbxSecurityAnswer.Focus();
                }
                else
                {
                    lblMsg.Text = "You select no method of restore. Please select first.";
                    txtbxEmail.Focus();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Failed to selection recovery method.\n\n" + ex.Message.ToString();
            }
        }

        protected void btnSubmitSecurityCode_Click(object sender, EventArgs e)
        {
            try
            {
                string email = hiddenFieldEmail.Value.ToString().Trim();
                string userCode = txtbxSecurityCode.Text.ToString().Trim();
                DatabaseHandler db = new DatabaseHandler();

                if (db.CheckUserExistsByEmail(email))
                {
                    if (hiddenFieldSecurityCode.Value.ToString().Trim() == userCode)
                    {
                        DataTable dt = db.GetUserByEmail(email);
                        Session["UserDetails"] = dt;
                        Session["LoggedInStatus"] = "Y";
                        Response.Redirect("~/user-hub.aspx");
                    }
                    else
                    {
                        lblMsg.Text = "Answer does not match.";
                    }
                }
                else
                {
                    lblMsg.Text = "User does not exists.";
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Failed to submit security code.\n\n" + ex.Message.ToString();
            }
        }

        protected void btnSubminQuestionAnswer_Click(object sender, EventArgs e)
        {
            try
            {
                string email = hiddenFieldEmail.Value.ToString().Trim();
                string userAnswer = txtbxSecurityAnswer.Text.ToString().Trim();
                DatabaseHandler db = new DatabaseHandler();

                if (db.CheckUserExistsByEmail(email))
                {
                    if (hiddenFieldSecurityAnswer.Value.ToString().Trim() == userAnswer)
                    {
                        DataTable dt = db.GetUserByEmail(email);
                        Session["UserDetails"] = dt;
                        Session["LoggedInStatus"] = "Y";
                        Response.Redirect("~/user-hub.aspx");
                    }
                    else
                    {
                        lblMsg.Text = "Answer does not match.";
                    }
                }
                else
                {
                    lblMsg.Text = "User does not exists.";
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = "Failed to submit your answer.\n\n" + ex.Message.ToString();
            }
        }
    }
}