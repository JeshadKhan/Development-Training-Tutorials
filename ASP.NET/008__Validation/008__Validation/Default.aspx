<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_008__Validation.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validation</title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="width: 66%;">

            <tr>
                <td colspan="3" style="text-align: center;">
                    <asp:Label ID="lblMsg" Text="President Election Form : Choose your president" runat="server" />
                </td>
            </tr>

            <tr>
                <td>Candidate:</td>

                <td>
                    <asp:DropDownList ID="drpdwnlstCandidate" runat="server" Style="width: 239px">
                        <asp:ListItem>Please Choose a Candidate</asp:ListItem>
                        <asp:ListItem>John Jones</asp:ListItem>
                        <asp:ListItem>Steve Taylor</asp:ListItem>
                        <asp:ListItem>Walter Abraham</asp:ListItem>
                        <asp:ListItem>Venus Williams</asp:ListItem>
                    </asp:DropDownList>
                </td>

                <td>
                    <asp:RequiredFieldValidator ID="rfvCandidate" runat="server" ControlToValidate="drpdwnlstCandidate" ErrorMessage="Please choose a candidate" InitialValue="Please choose a candidate"></asp:RequiredFieldValidator>
                </td>
            </tr>

            <tr>
                <td>House:</td>

                <td>
                    <asp:RadioButtonList ID="rdobtnlstHouse" runat="server" RepeatLayout="Flow">
                        <asp:ListItem>Red</asp:ListItem>
                        <asp:ListItem>Blue</asp:ListItem>
                        <asp:ListItem>Yellow</asp:ListItem>
                        <asp:ListItem>Green</asp:ListItem>
                    </asp:RadioButtonList>
                </td>

                <td>
                    <asp:RequiredFieldValidator ID="rfvHouse" runat="server" ControlToValidate="rdobtnlstHouse" ErrorMessage="Enter your house name"></asp:RequiredFieldValidator>
                </td>
            </tr>

            <tr>
                <td>Class:</td>

                <td>
                    <asp:TextBox ID="txtbxClass" runat="server"></asp:TextBox>
                </td>

                <td>
                    <asp:RangeValidator ID="rvClass" runat="server" ControlToValidate="txtbxClass" ErrorMessage="Enter your class (6 - 12)" MaximumValue="12" MinimumValue="6" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>

            <tr>
                <td>Email:</td>

                <td>
                    <asp:TextBox ID="txtbxEmail" runat="server" Style="width: 250px"></asp:TextBox>
                </td>

                <td>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtbxEmail" ErrorMessage="Enter your email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>

            <tr>
                <td colspan="3">
                    <asp:Button ID="btnSubmit" runat="server" Style="text-align: center;" Text="Submit" OnClick="btnSubmit_Click" />
                </td>
            </tr>
        </table>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="BulletList" ShowSummary="true" HeaderText="Errors:" />
    </form>
</body>
</html>
