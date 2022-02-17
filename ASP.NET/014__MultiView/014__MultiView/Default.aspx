<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_014__MultiView.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Multi View</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Multi View & View Controls</h1>
            <asp:DropDownList ID="drpdwnlstChangeView" runat="server" OnSelectedIndexChanged="drpdwnlstChangeView_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem>View1</asp:ListItem>
                <asp:ListItem>View2</asp:ListItem>
                <asp:ListItem>View3</asp:ListItem>
            </asp:DropDownList>
            <hr />
            <asp:MultiView ID="multiView" runat="server" ActiveViewIndex="0" OnActiveViewChanged="multiView_ActiveViewChanged">
                <asp:View ID="View1" runat="server">
                    <h3>This is View 1.</h3>
                    <asp:Button ID="btnPrev1" runat="server" Text="Previous" CommandName="SwitchViewByID" CommandArgument="View3" />
                    <asp:Button ID="btnNext1" runat="server" Text="Next" CommandName="NextView" />
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <h3>This is View 2.</h3>
                    <asp:Button ID="btnPrev2" runat="server" Text="Previous" CommandName="PrevView" />
                    <asp:Button ID="btnNext2" runat="server" Text="Next" CommandName="NextView" />
                </asp:View>
                <asp:View ID="View3" runat="server">
                    <h3>This is View 3.</h3>
                    <asp:Button ID="btnPrev3" runat="server" Text="Previous" CommandName="PrevView" />
                    <asp:Button ID="btnNext3" runat="server" Text="Next" CommandName="SwitchViewByIndex" CommandArgument="0" />
                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
