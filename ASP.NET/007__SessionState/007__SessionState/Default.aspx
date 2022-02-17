<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_007__SessionState.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Session State</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 568px; height: 103px">

                <tr>
                    <td style="width: 209px">
                        <asp:Label ID="lblString" runat="server" Text="Enter a String:" Style="width: 94px">
                        </asp:Label>
                    </td>

                    <td style="width: 317px">
                        <asp:TextBox ID="txtbxString" runat="server" Style="width: 227px">
                        </asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td style="width: 526px"></td>
                </tr>

                <tr>
                    <td style="width: 209px">
                        <asp:Button ID="btnNoAction" runat="server" Text="No Action Button" />
                    </td>

                    <td style="width: 317px">
                        <asp:Button ID="btnSubmitString" runat="server" Text="Submit the String" OnClick="btnSubmitString_Click"  />
                    </td>
                </tr>

                <tr>
                    <td style="width: 526px"></td>
                </tr>

                <tr>
                    <td style="width: 526px">
                        <asp:Label ID="lblSession" runat="server"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td style="width: 526px">
                        <asp:Label ID="lblSubmitString" runat="server"></asp:Label>
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
