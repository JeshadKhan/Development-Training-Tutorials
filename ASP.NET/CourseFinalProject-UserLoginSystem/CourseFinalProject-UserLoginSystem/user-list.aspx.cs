using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CourseFinalProject_UserLoginSystem
{
    public partial class user_list : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Session["UserDetails"];

            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["Email"].ToString().Trim() == "admin")
                {
                    GetUserListForAdmin();
                    GetActiveUserListForAdmin();
                    GetDeactiveUserListForAdmin();
                }
                else
                {
                    Response.Redirect("~/user-hub.aspx");
                }
            }
            else
            {
                Response.Redirect("~/login.aspx");
            }
        }

        private void GetUserListForAdmin()
        {
            try
            {
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = new DataTable();
                dt = db.GetUserListForAdmin();
                gridViewAllUser.DataSource = dt;
                gridViewAllUser.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Failed to load user list.\n\n" + ex.Message.ToString());
            }
        }

        private void GetActiveUserListForAdmin()
        {
            try
            {
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = new DataTable();
                dt = db.GetActiveUserListForAdmin();
                gridViewActiveUser.DataSource = dt;
                gridViewActiveUser.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Failed to load active user list.\n\n" + ex.Message.ToString());
            }
        }

        private void GetDeactiveUserListForAdmin()
        {
            try
            {
                DatabaseHandler db = new DatabaseHandler();
                DataTable dt = new DataTable();
                dt = db.GetDeactiveUserListForAdmin();
                gridViewDeactiveUser.DataSource = dt;
                gridViewDeactiveUser.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("Failed to load deactive user list.\n\n" + ex.Message.ToString());
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

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                gridViewAllUser.AllowPaging = false;
                gridViewAllUser.DataBind();

                StringWriter sw = new StringWriter();
                HtmlTextWriter htw = new HtmlTextWriter(sw);

                gridViewAllUser.RenderControl(htw);
                string gridHTML = sw.ToString().Replace("\"", "'").Replace(System.Environment.NewLine, "");

                StringBuilder sb = new StringBuilder();
                sb.Append("<script type = 'text/javascript'>");
                sb.Append("window.onload = new function(){");
                sb.Append("var printWin = window.open('', '', 'left=0");
                sb.Append(",top=0,width=1000,height=600,status=0');");
                sb.Append("printWin.document.write(\"");
                sb.Append(gridHTML);
                sb.Append("\");");
                sb.Append("printWin.document.close();");
                sb.Append("printWin.focus();");
                sb.Append("printWin.print();");
                sb.Append("printWin.close();};");
                sb.Append("</script>");

                ClientScript.RegisterStartupScript(this.GetType(), "UserListPrint", sb.ToString());
                gridViewAllUser.AllowPaging = true;
                gridViewAllUser.DataBind();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}