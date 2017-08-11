<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/RideXpress.Master" AutoEventWireup="true" CodeBehind="EditTask.aspx.cs" Inherits="RideXpress_StarterKit.EditTask" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h1>Edit / Re-assign Task</h1>
                </div>
            </div>
            <div class="form-horizontal">

                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="SelectCarLabel" runat="server" Text="Car"
                        AssociatedControlID="SelectCar" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-6">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:DropDownList ID="SelectCar" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                            <asp:ListItem Text="--Select a Car--" Value="-1"></asp:ListItem>
                        </asp:DropDownList>
                        <div class="has-error">
                            <span class="help-block">
                                <!--Validation Controls go here-->
                                <asp:RequiredFieldValidator ID="SelectCarRequired" runat="server" ErrorMessage="Car is Required" InitialValue="-1"
                                    ControlToValidate="SelectCar" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="TaskTitleLabel" runat="server" Text="Task Title"
                        AssociatedControlID="TaskTitle" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-6">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:TextBox ID="TaskTitle" runat="server" CssClass="form-control" MaxLength="50" TextMode="SingleLine"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <!--Validation Controls go here-->
                                <asp:RequiredFieldValidator ID="TaskTitleRequired" runat="server" ErrorMessage="Task Title is Required"
                                    ControlToValidate="TaskTitle" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="TaskDescriptionLabel" runat="server" Text="Task Description"
                        AssociatedControlID="TaskDescription" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-6">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:TextBox ID="TaskDescription" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="5" MaxLength="200"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <!--Validation Controls go here-->
                                <asp:RequiredFieldValidator ID="TaskDescriptionRequired" runat="server" ErrorMessage="Task Description is Required"
                                    ControlToValidate="TaskDescription" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="AssignedEmployeeLabel" runat="server" Text="Assigned Employee"
                        AssociatedControlID="AssignedEmployee" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-6">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:DropDownList ID="AssignedEmployee" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                            <asp:ListItem Text="--Select an Employee--" Value="-1"></asp:ListItem>
                        </asp:DropDownList>
                        <div class="has-error">
                            <span class="help-block">
                                <!--Validation Controls go here-->
                                <asp:RequiredFieldValidator ID="AssignedEmployeeRequired" runat="server" ErrorMessage="Assigned Employee is Required" InitialValue="-1"
                                    ControlToValidate="AssignedEmployee" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-xs-4 col-xs-offset-4">
                        <!--This is where your Submit button will go, you will use the OnClick Event to grab data from the form-->
                        <asp:Button ID="TaskEditButton" runat="server" Text="Submit" CssClass="btn btn-success"
                            OnClick="TaskEditButton_Click" ValidationGroup="AllValidators" />
                        <asp:HyperLink CssClass="btn btn-default" NavigateUrl="~/Tasks.aspx" runat="server" Text="Back" />
                    </div>
                </div>

            </div>
        </div>
    </section>
</asp:Content>
