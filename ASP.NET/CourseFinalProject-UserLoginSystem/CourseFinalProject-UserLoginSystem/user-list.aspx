<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="user-list.aspx.cs" Inherits="CourseFinalProject_UserLoginSystem.user_list" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <asp:Literal Text="User List -" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <%-- User List only for Admin --%>
    <div class="container padding-top-bottom-50px">
        <div class="row">
            <div class="col-md-12 padding-top-bottom-10px">
                <asp:GridView ID="gridViewAllUser" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" EmptyDataText="There has no data in all user table." CssClass="table table-striped">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12 padding-top-bottom-10px">
                <asp:GridView ID="gridViewActiveUser" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" EmptyDataText="There has no data in active user table." CssClass="table table-striped">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12 padding-top-bottom-10px">
                <asp:GridView ID="gridViewDeactiveUser" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" EmptyDataText="There has no data in deactive user table." CssClass="table table-striped">
                    <AlternatingRowStyle BackColor="White" />
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
            </div>
        </div>

        <div class="row padding-top-bottom-10px text-center well">
            <div class="col-md-12">
                <asp:Button ID="btnDashboard" runat="server" Text="Dashboard" CssClass="btn btn-primary" OnClick="btnDashboard_Click" />
                <%--<asp:Button ID="btnPrint" runat="server" Text="Print All User List" CssClass="btn btn-info" OnClick="btnPrint_Click" />--%>
                <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn btn-danger" OnClick="btnLogout_Click" />
            </div>
        </div>
    </div>
</asp:Content>
