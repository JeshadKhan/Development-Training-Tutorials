using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _019__ErrorHandling
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[,] quotes =
                {
                    {"Imagination is more important than Knowledge", "Albert Einsten"},
                    {"Assume a virtue, if you have it not", "Shakespeare"},
                    {"A man cannot be comfortable without his own approval", "Mark Twain"},
                    {"Beware the young doctor and the old barber", "Benjamin Franklin"},
                    {"Whatever begun in anger ends in shame", "Benjamin Franklin"}
                };

                for (int i = 0; i < quotes.GetLength(0); i++)
                {
                    drpdwnlstQuotes.Items.Add(new ListItem(quotes[i, 0], quotes[i, 1]));
                }


                // trace writing
                Trace.Write("Not Post Back, Page Load");


                // trace warning (here for just page load, you can apply any place)
                try
                {
                    int n = 0;
                    int eqation = 9 / n;
                }
                catch (Exception ex)
                {
                    Trace.Warn("UserAction", "processing: 9/0", ex);
                }
            }
            else
            {
                // trace writing
                Trace.Write("Post Back");
            }

            
        }

        protected void drpdwnlstQuotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drpdwnlstQuotes.SelectedIndex!=-1)
            {
                lblQuote.Text = String.Format("{0}, Quote: {1}", drpdwnlstQuotes.SelectedItem.Text, drpdwnlstQuotes.SelectedValue);
            }
        }
    }
}