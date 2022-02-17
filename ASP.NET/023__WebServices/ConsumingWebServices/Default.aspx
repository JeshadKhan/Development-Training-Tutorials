<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Services</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Using the Stock Service</h3>
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnPostBack" runat="server" Text="Post Back" OnClick="btnPostBack_Click" />
            <asp:Button ID="btnService" runat="server" Text="Service" OnClick="btnService_Click" />
        </div>
    </form>
</body>
</html>
