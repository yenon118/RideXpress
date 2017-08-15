<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/RideXpress.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RideXpress_StarterKit.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h1>Login</h1>
                </div>
            </div>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label ID="UsernameLabel" runat="server" Text="Username"
                        AssociatedControlID="Username" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Username" runat="server" CssClass="form-control" MaxLength="100" TextMode="SingleLine"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="UsernameRequired" runat="server" ErrorMessage="Username is Required"
                                    ControlToValidate="Username" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="InputPasswordLabel" runat="server" Text="Password"
                        AssociatedControlID="InputPassword" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="InputPassword" runat="server" CssClass="form-control" MaxLength="100" TextMode="Password"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="InputPasswordRequired" runat="server" ErrorMessage="Password is Required"
                                    ControlToValidate="InputPassword" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                        <asp:Label ID="InvalidLoginText" runat="server" Text="" CssClass="col-xs-7 control-label"></asp:Label>
                </div>
                <div class="form-group">
                    <div class="col-xs-4 col-xs-offset-4">
                        <asp:Button ID="LoginSubmitButton" runat="server" Text="Login" CssClass="btn btn-success"
                            OnClick="LoginSubmitButton_Click" ValidationGroup="AllValidators" />
                        <asp:HyperLink CssClass="btn btn-default" NavigateUrl="~/Index.aspx" runat="server" Text="Cancel" />
                    </div>
                </div>

            </div>
        </div>
    </section>
</asp:Content>
