using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;

namespace _011__FileUpload
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if (fileUpload.HasFile)
            {
                try
                {
                    sb.AppendFormat("Uploading file: {0}", fileUpload.FileName);

                    // saving the file
                    fileUpload.SaveAs(HttpContext.Current.Request.PhysicalApplicationPath + "\\+images\\" + fileUpload.FileName);

                    // showing the file information
                    sb.AppendFormat("<br /> Save As: {0}", fileUpload.PostedFile.FileName);
                    sb.AppendFormat("<br /> File Type: {0}", fileUpload.PostedFile.ContentType);
                    sb.AppendFormat("<br /> File Length: {0} KB or {1} MB", (double)(fileUpload.PostedFile.ContentLength / 1024), Math.Round((double)(fileUpload.PostedFile.ContentLength / 1024) / 1024, 2));
                    sb.AppendFormat("<br /> File Name: {0}", fileUpload.PostedFile.FileName);
                }
                catch (Exception ex)
                {
                    sb.Append("<br /> Error <br />");
                    sb.AppendFormat("Unable to save file <br /> {0}", ex.ToString());
                }
                finally
                {
                    lblMessage.Text = sb.ToString();
                }
            }
            else
            {
                lblMessage.Text = "No file selected.";
            }
        }
    }
}