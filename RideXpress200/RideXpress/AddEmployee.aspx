<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/RideXpress.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="RideXpress_StarterKit.AddEmployee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h1>Add Employee</h1>
                </div>
            </div>
            <div class="form-horizontal">
                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="EmployeeFirstNameLabel" runat="server" Text="First Name"
                        AssociatedControlID="EmployeeFirstName" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:TextBox ID="EmployeeFirstName" runat="server" CssClass="form-control" MaxLength="50" TextMode="SingleLine"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <!--Validation Controls go here-->
                                <asp:RequiredFieldValidator ID="EmployeeFirstNameRequired" runat="server" ErrorMessage="First Name is Required" InitialValue="-1"
                                    ControlToValidate="EmployeeFirstName" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="EmployeeLastNameLabel" runat="server" Text="Last Name"
                        AssociatedControlID="EmployeeLastName" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:TextBox ID="EmployeeLastName" runat="server" CssClass="form-control" MaxLength="50" TextMode="SingleLine"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <!--Validation Controls go here-->
                                <asp:RequiredFieldValidator ID="EmployeeLastNameRequired" runat="server" ErrorMessage="Last Name is Required" InitialValue="-1"
                                    ControlToValidate="EmployeeLastName" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="EmployeeGenderLabel" runat="server" Text="Gender"
                        AssociatedControlID="EmployeeGender" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:DropDownList ID="EmployeeGender" runat="server" CssClass="form-control">
                            <asp:ListItem Value="-1">--Select--</asp:ListItem>
                            <asp:ListItem Value="True">Male</asp:ListItem>
                            <asp:ListItem Value="False">Female</asp:ListItem>
                        </asp:DropDownList>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="EmployeeGenderRequired" runat="server" ErrorMessage="Gender is Required" InitialValue="-1"
                                    ControlToValidate="EmployeeGender" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="EmployeeBirthDateLabel" runat="server" Text="Birth Date"
                        AssociatedControlID="EmployeeBirthDate" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:TextBox ID="EmployeeBirthDate" runat="server" CssClass="form-control" MaxLength="50" TextMode="Date"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                            <!--Validation Controls go here-->
                            <asp:RequiredFieldValidator ID="EmployeeBirthDateRequired" runat="server" ErrorMessage="Birth date is Required" 
                                ControlToValidate="EmployeeBirthDate" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="EmployeeBirthDateValidator" runat="server" ControlToValidate="EmployeeBirthDate" Display="Dynamic"
                                ValidationGroup="AllValidators" ErrorMessage="Please enter a valid birth date." Type="Date"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="EmployeeJobTitleLabel" runat="server" Text="Job Title"
                        AssociatedControlID="EmployeeJobTitle" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:TextBox ID="EmployeeJobTitle" runat="server" CssClass="form-control" MaxLength="50" TextMode="SingleLine"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <!--Validation Controls go here-->
                                <asp:RequiredFieldValidator ID="EmployeeJobTitleRequired" runat="server" ErrorMessage="Last Name is Required" InitialValue="-1"
                                    ControlToValidate="EmployeeJobTitle" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="EmployeeStartDateLabel" runat="server" Text="Start Date"
                        AssociatedControlID="EmployeeStartDate" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:TextBox ID="EmployeeStartDate" runat="server" CssClass="form-control" MaxLength="50" TextMode="Date"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                            <!--Validation Controls go here-->
                            <asp:RequiredFieldValidator ID="EmployeeStartDateRequired" runat="server" ErrorMessage="Start date is Required" 
                                ControlToValidate="EmployeeStartDate" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="EmployeeStartDateValidator" runat="server" ControlToValidate="EmployeeStartDate" Display="Dynamic"
                                ValidationGroup="AllValidators" ErrorMessage="Please enter a valid start date." Type="Date"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-4 col-xs-offset-4">
                        <!--This is where your Submit button will go, you will use the OnClick Event to grab data from the form-->
                        <asp:Button ID="EmployeeAddButton" runat="server" Text="Submit" CssClass="btn btn-success"
                            OnClick="EmployeeAddButton_Click" ValidationGroup="AllValidators" />
                        <asp:HyperLink CssClass="btn btn-default" NavigateUrl="~/CurrentEmployees.aspx" runat="server" Text="Back" />
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
