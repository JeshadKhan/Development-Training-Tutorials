<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_018__Personalization.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Personalization</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tbody>
                    <tr>
                        <td>Name :</td>
                        <td>
                            <asp:TextBox ID="txtbxName" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Street :</td>
                        <td>
                            <asp:TextBox ID="txtbxStreet" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>City :</td>
                        <td>
                            <asp:TextBox ID="txtbxCity" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>State :</td>
                        <td>
                            <asp:TextBox ID="txtbxState" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Zip Code :</td>
                        <td>
                            <asp:TextBox ID="txtbxZipCode" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Date of Birth :</td>
                        <td>
                            <asp:Calendar ID="clndrDOB" runat="server"></asp:Calendar>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td></td>
                        <td>
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </form>
</body>
</html>
