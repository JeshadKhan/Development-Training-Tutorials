<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_015__Panel.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Panel</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="pnlDynamicControlGeneration" runat="server" BorderStyle="Double" BorderWidth="1px" ScrollBars="Auto" HorizontalAlign="Center">
                This panel shows dynamic control generation:
                <br />
                <br />
            </asp:Panel>
        </div>

        <table>
            <tr>
                <td>No of Labels: </td>
                <td>
                    <asp:DropDownList ID="drpdwnlstTotalLabel" runat="server" AutoPostBack="false">
                        <asp:ListItem>0</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td></td>
                <td></td>
            </tr>

            <tr>
                <td>No of Text Boxes: </td>
                <td>
                    <asp:DropDownList ID="drpdwnlstTotalTextBoxes" runat="server" AutoPostBack="false">
                        <asp:ListItem>0</asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td></td>
                <td></td>
            </tr>

            <tr>
                <td>
                    <asp:CheckBox ID="chkbxPanelVisible" runat="server" Text="Make the Panel Visible" />
                </td>
                <td>
                    <asp:Button ID="btnRefreshPanel" runat="server" Text="Refresh Panel" OnClick="btnRefreshPanel_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
