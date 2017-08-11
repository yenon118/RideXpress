<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/RideXpress.Master" AutoEventWireup="true" CodeBehind="AllEmployees.aspx.cs" Inherits="RideXpress_StarterKit.Employees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">

            <div class="row">
                <div class="col-xs-6">
                     <h1>Employees List</h1>
                </div>
                <div class="col-xs-2" style="margin-top: 1em;">
                    <a href="~/AddEmployee.aspx" runat="server" class="btn btn-success" data-toggle="popover" data-title="Add New Employee" data-content="Click here to add a new employee." data-trigger="hover" data-placement="bottom">Add New Employee</a>
                </div>
                <div class="col-xs-2" style="margin-top: 1em;">
                    <button type="button" class="btn btn-default" data-toggle="modal" data-target="#TerminateEmployeeModal">Terminate Employee</button>
                    <!--<a href="#" runat="server" class="btn btn-success" data-toggle="modal" data-target="#TerminateEmployeeModal" data-title="Terminate Employees" data-content="Click here to see the Terminate Employee Form." data-trigger="hover" data-placement="bottom">Terminate Employee</a>-->
                </div>
                <div class="col-xs-2" style="margin-top: 1em;">
                    <a href="~/CurrentEmployees.aspx" runat="server" class="btn btn-success" data-toggle="popover" data-title="Current Employees" data-content="Click here to all current employees." data-trigger="hover" data-placement="bottom">Current Employees</a>
                </div>
            </div>

            <div class="row">
                <div class="col-lg-12 text-center">
                    <!--GridView goes here-->
                    <asp:GridView ID="EmployeeList" runat="server" CssClass="table table-bordered text-left"
                        AutoGenerateColumns="False" OnRowDeleting="EmployeeList_RowDeleting" DataKeyNames="EmployeeID" OnRowDataBound="EmployeeList_RowDataBound">
                        <Columns>
                            <asp:HyperLinkField Text="Edit" DataNavigateUrlFields="EmployeeID"
                                DataNavigateUrlFormatString="~/EditEmployee.aspx?EmployeeID={0}" ControlStyle-CssClass="btn btn-success btn-xs"
                                ItemStyle-CssClass="text-center" />
                            <asp:TemplateField ItemStyle-CssClass="text-center">
                                <ItemTemplate>
                                    <asp:Button runat="server" ID="DeleteButton" CommandName="Delete" Visible="false"
                                        CssClass="btn btn-xs btn-default" Text="Delete"
                                        OnClientClick="if(!confirm('Are you sure you wish to delete this Report?')) return false;" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Name" HeaderText="Name" />
                            <asp:BoundField DataField="GenderDisplay" HeaderText="Gender" />
                            <asp:BoundField DataField="BirthDate" HeaderText="Date Of Birth" />
                            <asp:BoundField DataField="JobTitle" HeaderText="Job Title" />
                            <asp:BoundField DataField="StartDate" HeaderText="Start Date" />
                            <asp:BoundField DataField="EndDate" HeaderText="End Date" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>


            <div class="modal fade" id="TerminateEmployeeModal" tabindex="-1" role="dialog" aria-labelledby="TerminateEmployeeModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">×</span>
                            </button>
                            <h3 class="modal-title" id="TerminateEmployeeModalLabel">Terminate Employee</h3>
                        </div>
                        <div class="modal-body">
                            <div class="form-horizontal">

                                <div class="form-group">
                                    <!--ASP.NET Label Control goes here-->
                                    <asp:Label ID="TerminateEmployeeNameLabel" runat="server" Text="Name"
                                        AssociatedControlID="TerminateEmployeeList" CssClass="col-xs-4 control-label"></asp:Label>
                                    <div class="col-xs-6">
                                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                                        <asp:DropDownList ID="TerminateEmployeeList" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                            <asp:ListItem Text="--Select a Name--" Value="-1"></asp:ListItem>
                                        </asp:DropDownList>
                                        <div class="has-error">
                                            <span class="help-block">
                                                <!--Validation Controls go here-->
                                                <asp:RequiredFieldValidator ID="TerminateEmployeeListRequired" runat="server" ErrorMessage="Name is Required" InitialValue="-1"
                                                    ControlToValidate="TerminateEmployeeList" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                            </span>
                                        </div>
                                    </div>
                                </div>

                                <div class="form-group">
                                    <!--ASP.NET Label Control goes here-->
                                    <asp:Label ID="TerminateEmployeeEndDateLabel" runat="server" Text="Date"
                                        AssociatedControlID="TerminateEmployeeEndDate" CssClass="col-xs-4 control-label"></asp:Label>
                                    <div class="col-xs-6">
                                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                                        <asp:TextBox ID="TerminateEmployeeEndDate" runat="server" CssClass="form-control" MaxLength="50" TextMode="Date"></asp:TextBox>
                                        <div class="has-error">
                                            <span class="help-block">
                                                <!--Validation Controls go here-->
                                                <asp:RequiredFieldValidator ID="TerminateEmployeeEndDateRequired" runat="server" ErrorMessage="Date is Required"
                                                    ControlToValidate="TerminateEmployeeEndDate" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                                <asp:RangeValidator ID="TerminateEmployeeEndDateValidator" runat="server" ControlToValidate="TerminateEmployeeEndDate" Display="Dynamic"
                                                    ValidationGroup="AllValidators" ErrorMessage="Please enter a valid date." Type="Date"></asp:RangeValidator>
                                            </span>
                                        </div>
                                    </div>
                                </div>

                            </div>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                            <asp:Button ID="TerminateEmployeeSubmitButton" runat="server" CssClass="btn btn-primary" Text="Submit" OnClick="TerminateEmployeeSubmitButton_Click" ValidationGroup="AllValidators" />
                        </div>
                    </div>
                </div>
            </div>


        </div>
    </section>
</asp:Content>
