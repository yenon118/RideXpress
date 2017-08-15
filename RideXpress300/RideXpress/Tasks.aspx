<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/RideXpress.Master" AutoEventWireup="true" CodeBehind="Tasks.aspx.cs" Inherits="RideXpress_StarterKit.Tasks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">
            <div class="row">
                <div class="col-xs-10">
                    <h1>Tasks List</h1>
                </div>
                <div class="col-xs-2" style="margin-top: 1em;">
                    <button type="button" class="btn btn-success" data-toggle="modal" data-target="#AddNewTaskModal">Add New Task</button>
                    <!--<a href="~/AddTask.aspx" runat="server" class="btn btn-success">Add New Task</a>-->
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12 text-center">
                    <asp:GridView ID="TaskList" runat="server" CssClass="table table-bordered text-left"
                        AutoGenerateColumns="False" OnRowEditing="TaskList_RowEditing" OnRowDeleting="TaskList_RowDeleting" DataKeyNames="TaskID" OnRowUpdating="TaskList_RowUpdating" OnRowDataBound="TaskList_RowDataBound">
                        <Columns>

                            <%--<asp:HyperLinkField Text="Edit" DataNavigateUrlFields="TaskID" 
                            DataNavigateUrlFormatString="~/EditTask.aspx?TaskID={0}" ControlStyle-CssClass="btn btn-success btn-xs"
                            ItemStyle-CssClass="text-center" />--%>

                            <asp:TemplateField ItemStyle-CssClass="text-center">
                                <ItemTemplate>
                                    <asp:Button runat="server" ID="EditButton" CommandName="Edit" 
                                        CssClass="btn btn-success btn-xs" Text="Edit" />
                                </ItemTemplate>
                            </asp:TemplateField>

                            <asp:TemplateField ItemStyle-CssClass="text-center">
                                <ItemTemplate>
                                    <asp:Button runat="server" ID="DeleteButton" CommandName="Delete"
                                        CssClass="btn btn-xs btn-default" Text="Delete"
                                        OnClientClick="if(!confirm('Are you sure you wish to delete this ride?')) return false;" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField ItemStyle-CssClass="text-center">
                                <ItemTemplate>
                                    <asp:Button runat="server" ID="MarkCompleteButton" CommandName="Update"
                                        CssClass="btn btn-xs btn-default" Text="Mark Complete"
                                        OnClientClick="if(!confirm('Are you sure you wish to mark this ride for completion?')) return false;" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Name" HeaderText="Name" />
                            <asp:BoundField DataField="TaskTitle" HeaderText="Task Title" />
                            <asp:BoundField DataField="TaskDescription" HeaderText="Task Description" />
                            <asp:BoundField DataField="EmployeeName" HeaderText="Assigned Employee" />
                            <asp:BoundField DataField="DateAssigned" HeaderText="Date Assigned" />
                            <asp:BoundField DataField="TaskStatusDisplay" HeaderText="Task Status" />
                            <asp:BoundField DataField="DateComplete" HeaderText="Date Complete" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>


            <div class="modal fade" id="AddNewTaskModal" tabindex="-1" role="dialog" aria-labelledby="AddNewTaskModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">×</span>
                            </button>
                            <h3 class="modal-title" id="AddNewTaskModalLabel">Add New Task</h3>
                        </div>
                        <div class="modal-body">
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

                            </div>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                            <asp:Button ID="TerminateEmployeeSubmitButton" runat="server" CssClass="btn btn-primary" Text="Submit" OnClick="AddNewTaskSubmitButton_Click" ValidationGroup="AllValidators" />
                        </div>
                    </div>
                </div>
            </div>




        </div>

    </section>
</asp:Content>
