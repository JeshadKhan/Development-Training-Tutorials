<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_006__ViewState.Default" EnableViewState="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View State</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Page Counter: 
            <asp:Label ID="lblCounter" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnAddCount" runat="server" Text="Add Count" OnClick="btnAddCount_Click" />
        </div>
    </form>
</body>
</html>
