using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseFinalProject_UserLoginSystem
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtbxEmail.Focus();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = txtbxEmail.Text.Trim().ToString();
            string password = txtbxPassword.Text.Trim().ToString();

            if (email != "" && password != "")
            {
                DatabaseHandler db = new DatabaseHandler();

                if (db.CheckUserExistsByEmail(email))
                {
                    if (db.VerifyUser(email, password))
                    {
                        DataTable dt = db.GetUserByEmail(email);
                        Session["UserDetails"] = dt;
                        Session["LoggedInStatus"] = "Y";
                        Response.Redirect("~/user-hub.aspx");
                    }
                    else
                    {
                        lblMsg.Text = "Wrong email and password.";
                    }
                }
                else
                {
                    //Session["Msg"] = lblMsg.Text = "You are not registered. If you first time, please sign up. It's free.";
                    Response.Redirect("~/signup.aspx");
                }
            }
            else
            {
                lblMsg.Text = "Fill up details.";
            }
        }
    }
}