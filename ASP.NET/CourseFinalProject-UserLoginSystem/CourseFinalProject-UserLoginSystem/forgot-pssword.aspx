<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="forgot-pssword.aspx.cs" Inherits="CourseFinalProject_UserLoginSystem.forgot_pssword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <asp:Literal Text="Forgot Password -" runat="server" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <%-- Forgot Password Div --%>
    <div class="container padding-top-bottom-50px form-middle-signup">
        <div class="row">
            <h3>Forgot Password</h3>
        </div>

        <div class="row" id="divSelection" runat="server">
            <div class="row">
                <div class="col-md-12">
                    <p class="text-justify">
                        You can restore your account with two ways. Select your one.
                    </p>
                </div>
            </div>
            <div class="row">
                <div class="col-md-8">
                    <div class="form-group">
                        <label for="exampleInputEmail">Email address</label>
                        <asp:TextBox ID="txtbxEmail" runat="server" CssClass="form-control" placeholder="Email" required="required" TextMode="SingleLine" AutoCompleteType="Email"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-4">
                    <asp:RadioButtonList ID="rdibtnlstSelection" runat="server">
                        <asp:ListItem Text="By Sending Code" Value="SC" />
                        <asp:ListItem Text="By Question & Answer" Value="QA" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="row text-center">
                <asp:Button ID="btnSubmitEmail" runat="server" Text="Submit" CssClass="btn btn-success btn-lg" OnClick="btnSubmitEmail_Click" />
            </div>
        </div>

        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <label for="exampleInputMessage1">
                        <asp:Label ID="lblMsg" runat="server" Text="" CssClass="text-danger"></asp:Label>
                    </label>
                </div>
            </div>
        </div>

        <div class="row" id="divSecurityCode" runat="server" visible="false">
            <div class="row">
                <div class="col-md-12">
                    <div class="form-group">
                        <label for="exampleInputSecurityCode">Security Code</label>
                        <asp:TextBox ID="txtbxSecurityCode" runat="server" CssClass="form-control" placeholder="Security Code" TextMode="SingleLine"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row text-center padding-top-bottom-10px">
                <asp:Button ID="btnSubmitSecurityCode" runat="server" Text="Submit Code" CssClass="btn btn-success btn-lg" OnClick="btnSubmitSecurityCode_Click" />
            </div>
        </div>

        <div class="row" id="divQuestionAnswer" runat="server" visible="false">
            <div class="row">
                <div class="col-md-4">
                    <p>Question:</p>
                </div>
                <div class="col-md-8">
                    <asp:Label ID="lblSecurityQuestion" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <p>Answer:</p>
                </div>
                <div class="col-md-8">
                    <asp:TextBox ID="txtbxSecurityAnswer" runat="server" CssClass="form-control" placeholder="Answer" TextMode="SingleLine"></asp:TextBox>
                </div>
            </div>
            <div class="row text-center padding-top-bottom-10px">
                <asp:Button ID="btnSubminQuestionAnswer" runat="server" Text="Submit Answer" CssClass="btn btn-success btn-lg" OnClick="btnSubminQuestionAnswer_Click" />
            </div>
        </div>
    </div>

    <asp:HiddenField ID="hiddenFieldEmail" runat="server" />
    <asp:HiddenField ID="hiddenFieldSecurityCode" runat="server" />
    <asp:HiddenField ID="hiddenFieldSecurityAnswer" runat="server" />
</asp:Content>
