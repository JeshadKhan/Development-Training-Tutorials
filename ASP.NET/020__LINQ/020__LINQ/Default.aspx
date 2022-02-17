<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_020__LINQ.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LINQ</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Books Title</h1>
            <asp:Label ID="lblBooksTitle" runat="server" Text=""></asp:Label>
            <hr />
            <h1>Books Details with Pages</h1>
            <asp:Label ID="lblBooksDetail" runat="server" Text=""></asp:Label>
            <hr />
            <h1>Books That Sales Ten Thousand Times</h1>
            <asp:Label ID="lblBooksThatSalesTenThousandTimes" runat="server" Text=""></asp:Label>
            <hr />
            <h1>Books Title and Total Sale</h1>
            <asp:Label ID="lblBooksTitleAndTotalSale" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
