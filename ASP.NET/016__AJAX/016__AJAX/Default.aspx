<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_016__AJAX.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AJAX</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="scriptManager" runat="server"></asp:ScriptManager>
            <%--<asp:Timer ID="tmrTotal" runat="server" Interval="1000"></asp:Timer>--%>
        </div>

        <asp:UpdatePanel ID="updatePanel" runat="server">
            <ContentTemplate>
                <h3>Inside Update Panel:</h3>
                <asp:Label ID="lblPartial" runat="server" Text=""></asp:Label>
                <br />
                <br />
                <asp:Button ID="btnPartial" runat="server" Text="Partial PostBack" />
                <asp:Timer ID="tmrPanel" runat="server" Interval="1000"></asp:Timer>
            </ContentTemplate>
        </asp:UpdatePanel>

        <hr />

        <div>
            <h3>Outside Update Panel:</h3>
            <asp:Label ID="lblTotal" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnTotal" runat="server" Text="Total PostBack" />
        </div>
    </form>
</body>
</html>
