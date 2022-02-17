<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="CourseFinalProject_UserLoginSystem.signup" %>

<asp:Content ID="head" ContentPlaceHolderID="head" runat="server">
    <asp:Literal Text="Sign Up -" runat="server" />
</asp:Content>

<asp:Content ID="body" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <%-- Sign Up Div --%>
    <div class="container padding-top-bottom-50px form-middle-signup">
        <div class="row">
            <div class="form-group">
                <label for="exampleInputMessage1">
                    <asp:Label ID="lblMsg" runat="server" Text="" CssClass="text-danger"></asp:Label>
                </label>
                <asp:Label ID="lblWelcome" runat="server" Text="" CssClass="text-primary"></asp:Label>
                <asp:HyperLink ID="hyperLinkLogin" runat="server" NavigateUrl="~/login.aspx" Visible="false">Now Login</asp:HyperLink>
            </div>
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
                    <label for="exampleInputPassword">Password</label>
                    <asp:TextBox ID="txtbxPassword" runat="server" CssClass="form-control password" placeholder="Password" required="required" TextMode="Password"></asp:TextBox>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-group">
                    <label for="exampleInputConfirmPassword">Confirm Password</label>
                    <asp:TextBox ID="txtbxConfirmPassword" runat="server" CssClass="form-control password" placeholder="Confirm Password" TextMode="Password"></asp:TextBox>
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
        <div class="row">
            <div class="col-md-8">
                <div class="form-group">
                    <label for="exampleInputEmail">Email address</label>
                    <asp:TextBox ID="txtbxEmail" runat="server" CssClass="form-control" placeholder="Email" required="required" TextMode="SingleLine" AutoCompleteType="Email"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="emailValidator" runat="server" ErrorMessage="Invalid email." ForeColor="Red" ControlToValidate="txtbxEmail" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="col-md-4 text-center">
                <div class="form-group text-center">
                    <div class="checkbox">
                        <label>
                            <input id="chkbxPasswordVisible" type="checkbox" onclick="textModeChanger()" style="outline: none;" />
                            Visible Password.
                        </label>
                    </div>
                </div>
                <div class="form-group">
                    <div class="checkbox">
                        <label>
                            <asp:CheckBox ID="chkbxActivationStatus" runat="server" />
                            User Activation.
                        </label>
                    </div>
                </div>
            </div>
        </div>

        <div class="row text-center">
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-success btn-lg text-center" OnClick="btnSubmit_Click" />
        </div>
    </div>

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
