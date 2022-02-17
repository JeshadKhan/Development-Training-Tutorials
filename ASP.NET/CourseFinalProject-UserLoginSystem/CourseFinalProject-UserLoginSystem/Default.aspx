<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CourseFinalProject_UserLoginSystem.Default" %>

<asp:Content ID="head" ContentPlaceHolderID="head" runat="server">
    <%--<asp:Literal Text="Home -" runat="server" />--%>
</asp:Content>

<asp:Content ID="body" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <h1 class="padding-top-bottom-10px text-center">Wish You Happy New Year -
        <asp:Label ID="lblYear" runat="server" Text=""></asp:Label></h1>
    <p class="text-center text-info">
        Today is:<br/>
        <asp:Label ID="lblToday" runat="server" Text=""></asp:Label>
    </p>    
</asp:Content>
