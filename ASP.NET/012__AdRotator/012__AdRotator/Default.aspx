<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_012__AdRotator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ad Rotator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:AdRotator ID="adRotator" runat="server" AdvertisementFile="~/ads.xml" OnAdCreated="adRotator_AdCreated" />
        </div>
    </form>
</body>
</html>
