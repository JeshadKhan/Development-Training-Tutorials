using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _015__Panel
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDynamicControlGeneration.Visible = false;
        }

        protected void btnRefreshPanel_Click(object sender, EventArgs e)
        {
            // generating the label controls
            for (int i = 1; i <= Int32.Parse(drpdwnlstTotalLabel.SelectedItem.Value); i++)
            {
                Label lbl = new Label();
                lbl.Text = "Label" + i.ToString();
                pnlDynamicControlGeneration.Controls.Add(lbl);
                pnlDynamicControlGeneration.Controls.Add(new LiteralControl("<br />"));
            }

            // generating the text box controls
            for (int i = 1; i <= Int32.Parse(drpdwnlstTotalTextBoxes.SelectedItem.Value); i++)
            {
                TextBox txtbx = new TextBox();
                txtbx.Text = "TextBox" + i.ToString();
                pnlDynamicControlGeneration.Controls.Add(txtbx);
                pnlDynamicControlGeneration.Controls.Add(new LiteralControl("<br />"));
            }

            // make visible the panel
            if (chkbxPanelVisible.Checked)
            {
                pnlDynamicControlGeneration.Visible = true;
            }
        }
    }
}