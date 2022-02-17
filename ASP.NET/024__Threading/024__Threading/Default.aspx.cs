using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Threading;

namespace _024__Threading
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ThreadStart childThread = new ThreadStart(ChildThreadCall);
            Response.Write("Thread started. Child thread started.");
            Thread thread = new Thread(childThread);

            thread.Start();

            Response.Write("<br />Main method sleeping for 3 seconds.");
            Thread.Sleep(3000);
            Response.Write("<br />Main method aborting child thread.");

            thread.Abort();
        }

        public void ChildThreadCall()
        {
            try
            {
                lblStatus.Text += "<br />Hello from child thread.<br />Child thread counting to 10.";

                for (int i = 1; i <= 10; i++)
                {
                    Thread.Sleep(500);
                    lblStatus.Text += "<br />Count: " + i.ToString();
                }

                lblStatus.Text += "<br />Counting of child thread is finished.";
            }
            catch (ThreadAbortException)
            {
                lblStatus.Text += "<br />Child thread abort exception.";
            }
            finally
            {
                lblStatus.Text += "<br />Child thread finally finish the task.";
            }
        }
    }
}