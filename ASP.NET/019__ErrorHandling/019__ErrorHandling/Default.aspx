<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_019__ErrorHandling.Default" Trace="true" ErrorPage="ErrorPage.html" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Debugging, Tracing and Error Handling</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="drpdwnlstQuotes" runat="server" AutoPostBack="true" OnSelectedIndexChanged="drpdwnlstQuotes_SelectedIndexChanged"></asp:DropDownList>
            <br /><br />
            <asp:Label ID="lblQuote" runat="server" Text="Label"></asp:Label>
            <br /><br />
            <asp:HyperLink ID="hyperLink" runat="server" NavigateUrl="myLink.html">Link to:</asp:HyperLink>
        </div>
    </form>
</body>
</html>
