<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_013__Calender.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calender</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="calendar" runat="server" SelectionMode="DayWeekMonth" OnSelectionChanged="calendar_SelectionChanged"></asp:Calendar>
            <br /><br />
            <asp:Label ID="lblToday" runat="server" Text="Today is:"></asp:Label>
            <br /><br />
            <asp:Label ID="lblBirthday" runat="server" Text="Birthday is:"></asp:Label>
        </div>
    </form>
</body>
</html>
