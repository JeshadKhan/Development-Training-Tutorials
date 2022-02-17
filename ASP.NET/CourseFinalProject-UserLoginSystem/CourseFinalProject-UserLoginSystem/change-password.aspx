<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="change-password.aspx.cs" Inherits="CourseFinalProject_UserLoginSystem.change_password" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <asp:Literal Text="Change Password -" runat="server" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <%-- Change Password --%>
    <div class="row padding-top-bottom-10px">
        <div class="form-group">
            <label for="exampleInputMessage1">
                <asp:Label ID="lblMsg" runat="server" Text="" CssClass="text-danger"></asp:Label>
            </label>
        </div>

        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label for="exampleInputPassword">Password</label>
                    <asp:TextBox ID="txtbxPassword" runat="server" CssClass="form-control password" placeholder="Password" TextMode="Password"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label for="exampleInputConfirmPassword">Confirm Password</label>
                    <asp:TextBox ID="txtbxConfirmPassword" runat="server" CssClass="form-control password" placeholder="Confirm Password" TextMode="Password"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="form-group text-center">
            <div class="checkbox padding-top-bottom-10px">                
                <label>
                    <input id="chkbxPasswordVisible" type="checkbox" onclick="textModeChanger()" style="outline: none;" />
                    Visible Password.
                </label>
            </div>
            <asp:Button ID="btnChange" runat="server" Text="Change" CssClass="btn btn-success btn-lg" OnClick="btnChange_Click" />
        </div>
    </div>

    <div class="row padding-top-bottom-10px text-center well">
        <div class="col-md-12">
            <asp:Button ID="btnDashboard" runat="server" Text="Dashboard" CssClass="btn btn-primary" OnClick="btnDashboard_Click" />
            <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn btn-danger" OnClick="btnLogout_Click" />
        </div>
    </div>

    <asp:HiddenField ID="hiddenFieldUserId" runat="server" />

    <script type="text/javascript">
        function textModeChanger() {
            if (chkbxPasswordVisible.checked) {
                $('.password').attr('type', 'text');
            }
            else {
                $('.password').attr('type', 'password');
            }
        }
    </script>
</asp:Content>
