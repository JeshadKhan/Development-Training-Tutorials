<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="edit-user-info.aspx.cs" Inherits="CourseFinalProject_UserLoginSystem.edit_user_info" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <asp:Literal Text="Edit -" runat="server" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <%-- Edit User Information --%>
    <div class="row padding-top-bottom-10px">
        <div class="form-group">
            <label for="exampleInputMessage1">
                <asp:Label ID="lblMsg" runat="server" Text="" CssClass="text-danger"></asp:Label>
            </label>
        </div>

        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label for="exampleInputFirstName">First Name</label>
                    <asp:TextBox ID="txtbxFirstName" runat="server" CssClass="form-control" placeholder="First Name" TextMode="SingleLine"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label for="exampleInputLastName">Last Name</label>
                    <asp:TextBox ID="txtbxLastName" runat="server" CssClass="form-control" placeholder="Last Name" TextMode="SingleLine"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
                <div class="form-group">
                    <label for="exampleInputSecurityQuestion">Security Question</label>
                    <asp:TextBox ID="txtbxSecurityQuestion" runat="server" CssClass="form-control" placeholder="Security Question" TextMode="SingleLine"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label for="exampleInputSecurityAnswer">Security Answer</label>
                    <asp:TextBox ID="txtbxSecurityAnswer" runat="server" CssClass="form-control" placeholder="Security Answer" TextMode="SingleLine"></asp:TextBox>
                </div>
            </div>
        </div>

        <div class="form-group text-center">
            <div class="checkbox">
                <label>
                    <asp:CheckBox ID="chkbxActivationStatus" runat="server" />
                    Activation.
                </label>
            </div>
            <asp:Button ID="btnChange" runat="server" Text="Change" CssClass="btn btn-success btn-lg text-center" OnClick="btnChange_Click" />
        </div>
    </div>

    <div class="row padding-top-bottom-10px text-center well">
        <div class="col-md-12">
            <asp:Button ID="btnDashboard" runat="server" Text="Dashboard" CssClass="btn btn-primary" OnClick="btnDashboard_Click" />
            <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn btn-danger" OnClick="btnLogout_Click" />
        </div>
    </div>

    <asp:HiddenField ID="hiddenFieldUserId" runat="server" />
</asp:Content>
