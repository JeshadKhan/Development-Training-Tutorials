<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_017__CustomControl.Default" %>

<%@ Register Src="~/Controls/footer.ascx" TagPrefix="control" TagName="footer" %>

<%@ Register Assembly="CustomControl" Namespace="CustomControl" TagPrefix="cc" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Custom Control</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>
            User Control & Custom Control Example
        </h1>

        <div>
            <cc:ServerControl1 ID="ServerControl1" runat="server" Text="This is a Custom Server Control."></cc:ServerControl1>
            <hr />
            <asp:TextBox ID="txtbxText" runat="server" Text="wow"></asp:TextBox>
            <asp:Button ID="btnCheckPalindrome" runat="server" Text="Check Palindrome" OnClick="btnCheckPalindrome_Click" />
            <cc:ServerControl2 ID="customControl" runat="server" Text="wow"></cc:ServerControl2>
        </div>

        <%-- Here footer is a User Control --%>
        <control:footer runat="server" id="footer" />
    </form>
</body>
</html>
