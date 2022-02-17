<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_001__FirstExample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>First Example</title>
</head>
<body>
    <h1>Conversion to Upper</h1>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtbxText" runat="server"></asp:TextBox>
        <asp:Button ID="btnChange" runat="server" Text="Change" OnClick="btnChange_Click" />
        <hr />
        <strong>Result:</strong> <asp:Label ID="lblChangedText" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
