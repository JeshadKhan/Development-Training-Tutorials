using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _004__ServerControls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblParentNode.Text = string.Empty;
            txtbxChildNode.Text = string.Empty;
        }

        protected void treeViewWeb_SelectedNodeChanged(object sender, EventArgs e)
        {
            // insert parent node to parent label
            if (treeViewWeb.SelectedNode.Parent == null)
            {
                lblParentNode.Text = "Root";
            }
            else
            {
                lblParentNode.Text = treeViewWeb.SelectedNode.Parent.Text;
            }

            // insert selected node to selected label
            lblSelectedNode.Text = treeViewWeb.SelectedNode.Text;

            // clear all the previous data from the child textbox
            txtbxChildNode.Text = string.Empty;

            // insert child nodes to the child textbox
            TreeNodeCollection childNodes = treeViewWeb.SelectedNode.ChildNodes;

            if (childNodes != null)
            {
                foreach (TreeNode node in childNodes)
                {
                    txtbxChildNode.Text += node.Text + ", ";
                }

                // if have child, remove extra comma and space and add a full stop to end.
                if (!string.IsNullOrEmpty(txtbxChildNode.Text.Trim()))
                {
                    txtbxChildNode.Text = txtbxChildNode.Text.Remove((int)txtbxChildNode.Text.Length - 2, 2);
                    txtbxChildNode.Text += ".";
                }
            }
        }
    }
}