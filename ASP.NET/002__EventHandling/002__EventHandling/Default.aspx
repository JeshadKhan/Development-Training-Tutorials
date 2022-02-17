<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_002__EventHandling.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Event Handling</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMessage" runat="server" Text="Initial value.<br />"></asp:Label>
            <hr />
            <asp:Button ID="btnClick" runat="server" Text="Click" OnClick="btnClick_Click" />
        </div>
    </form>
</body>
</html>
