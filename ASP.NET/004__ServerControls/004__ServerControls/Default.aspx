<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_004__ServerControls.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Server Controls</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TreeView ID="treeViewWeb" runat="server" ImageSet="Arrows" OnSelectedNodeChanged="treeViewWeb_SelectedNodeChanged">
                <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                <Nodes>
                    <asp:TreeNode Text="Website" Value="Website">
                        <asp:TreeNode Text="Home" Value="Home"></asp:TreeNode>
                        <asp:TreeNode Text="About" Value="About">
                            <asp:TreeNode Text="History" Value="History"></asp:TreeNode>
                            <asp:TreeNode Text="Vision &amp; Mission" Value="Vision &amp; Mission"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="Gallery" Value="Gallery">
                            <asp:TreeNode Text="Photo" Value="Photo"></asp:TreeNode>
                            <asp:TreeNode Text="Video" Value="Video"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="Product" Value="Product">
                            <asp:TreeNode Text="Product Brief &amp; Demo" Value="Product Brief &amp; Demo"></asp:TreeNode>
                            <asp:TreeNode Text="Demo" Value="Demo"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="Service" Value="Service"></asp:TreeNode>
                        <asp:TreeNode Text="Portfolio" Value="Portfolio">
                            <asp:TreeNode Text="Company List" Value="Company List"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="Team" Value="Team">
                            <asp:TreeNode Text="CEO" Value="CEO"></asp:TreeNode>
                            <asp:TreeNode Text="CTO" Value="CTO"></asp:TreeNode>
                            <asp:TreeNode Text="CMO" Value="CMO"></asp:TreeNode>
                            <asp:TreeNode Text="CPO" Value="CPO"></asp:TreeNode>
                            <asp:TreeNode Text="Developers" Value="Developers"></asp:TreeNode>
                            <asp:TreeNode Text="Correspondent" Value="Correspondent"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="Contact" Value="Contact"></asp:TreeNode>
                    </asp:TreeNode>
                </Nodes>
                <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                <ParentNodeStyle Font-Bold="False" />
                <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
            </asp:TreeView>
        </div>
        <hr />
        <strong>Parent Node:</strong>
        <asp:Label ID="lblParentNode" runat="server" Text=""></asp:Label>
        <br />
        <strong>Selected Node:</strong>
        <asp:Label ID="lblSelectedNode" runat="server" Text=""></asp:Label>
        <br />
        <strong>Child Node:</strong>
        <asp:TextBox ID="txtbxChildNode" runat="server" style="width: 90%;"></asp:TextBox>
    </form>
</body>
</html>
