<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_005__HTMLServer.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HTML Server</title>

    <style type="text/css">
        .style1 {
            width: 156px;
        }

        .style2 {
            width: 332px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 54%;">
                <tr>
                    <td class="style1">Name:</td>
                    <td class="style2">
                        <asp:TextBox ID="txtbxName" runat="server" Style="width: 230px">
                        </asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="style1">Street</td>
                    <td class="style2">
                        <asp:TextBox ID="txtbxStreet" runat="server" Style="width: 230px">
                        </asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="style1">City</td>
                    <td class="style2">
                        <asp:TextBox ID="txtbxCity" runat="server" Style="width: 230px">
                        </asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="style1">State</td>
                    <td class="style2">
                        <asp:TextBox ID="txtbxState" runat="server" Style="width: 230px">
                        </asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="style1"></td>
                    <td class="style2"></td>
                </tr>

                <tr>
                    <td class="style1"></td>
                    <td id="displayRow" runat="server" class="style2"></td>
                </tr>
            </table>
        </div>
        <asp:Button ID="btnDisplay" runat="server" Text="Display" OnClick="btnDisplay_Click" />
    </form>
</body>
</html>
