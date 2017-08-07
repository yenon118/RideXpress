<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/RideXpress.Master" AutoEventWireup="true" CodeBehind="AddReport.aspx.cs" Inherits="RideXpress_StarterKit.AddReport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h1>New Incident Report</h1>
                </div>
            </div>
            <div class="form-horizontal">
                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="CarIDListLabel" runat="server" Text="Car Owner"
                        AssociatedControlID="CarIDList" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:DropDownList ID="CarIDList" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                            <asp:ListItem Text="--Select a ride--" Value="-1"></asp:ListItem>
                        </asp:DropDownList>
                        <div class="has-error">
                            <span class="help-block">
                                <!--Validation Controls go here-->
                                <asp:RequiredFieldValidator ID="CarIDListRequired" runat="server" ErrorMessage="Car is Required" InitialValue="-1"
                                    ControlToValidate="CarIDList" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="DateOfIncidentLabel" runat="server" Text="Date"
                        AssociatedControlID="DateOfIncident" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:TextBox ID="DateOfIncident" runat="server" CssClass="form-control" MaxLength="50" TextMode="Date"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                            <!--Validation Controls go here-->
                            <asp:RequiredFieldValidator ID="DateOfIncidentRequired" runat="server" ErrorMessage="Date is Required" 
                                ControlToValidate="DateOfIncident" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="DateOfIncidentValidator" runat="server" ControlToValidate="DateOfIncident" Display="Dynamic"
                                ValidationGroup="AllValidators" ErrorMessage="Please enter a valid date. Car older than 30 years are not accepted." Type="Date"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="ReportNameLabel" runat="server" Text="Reporter"
                        AssociatedControlID="ReportName" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:TextBox ID="ReportName" runat="server" CssClass="form-control" MaxLength="50" TextMode="SingleLine"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <!--Validation Controls go here-->
                                <asp:RequiredFieldValidator ID="ReportNameRequired" runat="server" ErrorMessage="Name of report is Required" 
                                    ControlToValidate="ReportName" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="ReportDescriptionLabel" runat="server" Text="Description"
                        AssociatedControlID="ReportDescription" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:TextBox ID="ReportDescription" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="5" MaxLength="200"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <!--Validation Controls go here-->
                                <asp:RequiredFieldValidator ID="ReportDescriptionRequired" runat="server" ErrorMessage="Report description is Required" 
                                    ControlToValidate="ReportDescription" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-4 col-xs-offset-4">
                        <!--This is where your Submit button will go, you will use the OnClick Event to grab data from the form-->
                        <asp:Button ID="ReportAddButton" runat="server" Text="Submit" CssClass="btn btn-success"
                            OnClick="ReportAddButton_Click" ValidationGroup="AllValidators" />
                        <asp:HyperLink CssClass="btn btn-default" NavigateUrl="~/Reports.aspx" runat="server" Text="Back" />
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
