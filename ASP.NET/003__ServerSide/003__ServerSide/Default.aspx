<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_003__ServerSide.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Server Side</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter your name:
            <asp:TextBox ID="txtbxName" runat="server"></asp:TextBox>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <hr />
            <asp:Label ID="lblShowResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
