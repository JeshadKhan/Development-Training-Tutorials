<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="user-hub.aspx.cs" Inherits="CourseFinalProject_UserLoginSystem.user_hub" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <asp:Literal ID="userHub" runat="server" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <%-- User Information Dashboard --%>
    <div class="info-div padding-top-bottom-10px">
        <div class="row well">
            <div class="col-md-4">
                <div class="row">
                    <div class="col-md-4">
                        First Name:
                    </div>
                    <div class="col-md-8">
                        <asp:Label ID="lblFirstName" runat="server" Text="" Font-Bold="true"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="row">
                    <div class="col-md-4">
                        Last Name:
                    </div>
                    <div class="col-md-8">
                        <asp:Label ID="lblLastName" runat="server" Text="" Font-Bold="true"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="row">
                    <div class="col-md-4">
                        Status:
                    </div>
                    <div class="col-md-8">
                        <asp:Label ID="lblStatus" runat="server" Text="" Font-Bold="true"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
        <div class="row well">
            <div class="col-md-6">
                <div class="row">
                    <div class="col-md-4">
                        Full Name:
                    </div>
                    <div class="col-md-8">
                        <asp:Label ID="lblFullName" runat="server" Text="" Font-Bold="true"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="row">
                    <div class="col-md-4">
                        Email:
                    </div>
                    <div class="col-md-8">
                        <asp:Label ID="lblEmail" runat="server" Text="" Font-Bold="true"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
        <div class="row well text-center">
            <asp:HyperLink ID="hyperLinkEditInfo" runat="server" CssClass="btn btn-success btn-lg" NavigateUrl="~/edit-user-info.aspx">Edit Information</asp:HyperLink>
            <asp:HyperLink ID="hyperLinkChangePassword" runat="server" CssClass="btn btn-success btn-lg" NavigateUrl="~/change-password.aspx">Change Password</asp:HyperLink>
            <asp:HyperLink ID="hyperLinkUserList" runat="server" CssClass="btn btn-success btn-lg" NavigateUrl="~/user-list.aspx" Visible="false">User List</asp:HyperLink>
        </div>

        <div class="row padding-top-bottom-50px text-center">
            <div class="col-md-12">
                <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn btn-danger" OnClick="btnLogout_Click" />
            </div>
        </div>
    </div>
</asp:Content>
