<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="CourseFinalProject_UserLoginSystem.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <asp:Literal Text="Login -" runat="server"></asp:Literal>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <%-- Login Div --%>
    <div class="row padding-top-bottom-50px form-middle-login">
        <div class="form-group">
            <label for="exampleInputMessage1">
                <asp:Label ID="lblMsg" runat="server" Text="" CssClass="text-danger"></asp:Label>
            </label>
        </div>
        <div class="form-group">
            <label for="exampleInputEmail1">Email address</label>
            <asp:TextBox ID="txtbxEmail" runat="server" CssClass="form-control" placeholder="Email" required="required" TextMode="SingleLine" AutoCompleteType="Email"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="exampleInputPassword1">Password</label>
            <asp:TextBox ID="txtbxPassword" runat="server" CssClass="form-control" placeholder="Password" required="required" TextMode="Password"></asp:TextBox>
        </div>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-primary col-md-12" OnClick="btnSubmit_Click" />
        <div class="form-group text-center padding-top-bottom-50px">
            Forgot your password?
            <asp:HyperLink ID="hyperLinkForgotPassword" runat="server" NavigateUrl="~/forgot-pssword.aspx">Reset it.</asp:HyperLink>
        </div>
    </div>
</asp:Content>
