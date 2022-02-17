<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataCaching.aspx.cs" Inherits="_022__Caching.DataCaching" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data Caching</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTime" runat="server" Text=""></asp:Label>
            <hr />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DataCachingTestConnectionString %>" SelectCommand="SELECT * FROM [Author]" EnableCaching="true" CacheDuration="60"></asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                    <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                    <asp:BoundField DataField="Topic" HeaderText="Topic" SortExpression="Topic" />
                    <asp:BoundField DataField="Publisher" HeaderText="Publisher" SortExpression="Publisher" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
