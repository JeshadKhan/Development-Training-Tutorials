<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_022__Caching.Default" %>

<%@ OutputCache Duration="60" VaryByParam="txtbxName" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Caching</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtbxName" runat="server"></asp:TextBox>
            <asp:Button ID="btnMagic" runat="server" Text="Magic" OnClick="btnMagic_Click" />
            <hr />
            <asp:HyperLink ID="hyperLinkDataCaching" runat="server" NavigateUrl="~/DataCaching.aspx">Data Caching</asp:HyperLink>
            <br />
            <asp:HyperLink ID="hyperLinkObjectCaching" runat="server" NavigateUrl="~/Object Caching.aspx">Object Caching</asp:HyperLink>
        </div>
    </form>
</body>
</html>
