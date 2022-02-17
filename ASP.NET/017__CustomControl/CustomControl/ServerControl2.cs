using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomControl
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:ServerControl2 runat=server></{0}:ServerControl2>")]
    public class ServerControl2 : WebControl
    {
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string Text
        {
            get
            {
                String s = (String)ViewState["Text"];
                return ((s == null) ? String.Empty : s);
            }

            set
            {
                ViewState["Text"] = value;
            }
        }

        protected override void RenderContents(HtmlTextWriter output)
        {
            if (this.checkPalindrome())
            {
                output.Write("<br /><br />This is a palindrome: ");
                output.Write("<font size=5 color=Blue>");
                output.Write("<b>");
                output.Write(Text);
                output.Write("</b>");
                output.Write("</font>");
            }
            else
            {
                output.Write("<br /><br />This is not a palindrome: ");
                output.Write("<font size=5 color=red>");
                output.Write("<b>");
                output.Write(Text);
                output.Write("</b>");
                output.Write("</font>");
            }
        }

        protected bool checkPalindrome()
        {
            if (this.Text != null)
            {
                string str = this.Text.Trim().ToString();
                char[] strArray = str.ToCharArray();
                Array.Reverse(strArray);
                string rev = new string(strArray);

                if (str == rev)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
