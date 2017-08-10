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
                    <a href="~/AddTask.aspx" runat="server" class="btn btn-success">Add New Task</a>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12 text-center">
                    <asp:GridView ID="TaskList" runat="server" CssClass="table table-bordered text-left"
                        AutoGenerateColumns="False" OnRowDeleting="TaskList_RowMarkComplete" DataKeyNames="TaskID">
                        <Columns>
                            <asp:HyperLinkField Text="Edit" DataNavigateUrlFields="TaskID"
                                DataNavigateUrlFormatString="~/EditTask.aspx?TaskID={0}" ControlStyle-CssClass="btn btn-success btn-xs"
                                ItemStyle-CssClass="text-center" />
                            <asp:TemplateField ItemStyle-CssClass="text-center">
                                <ItemTemplate>
                                    <asp:Button runat="server" ID="MarkCompleteButton" CommandName="MarkComplete"
                                        CssClass="btn btn-xs btn-default" Text="Mark Complete"
                                        OnClientClick="if(!confirm('Are you sure you wish to mark this ride for completion?')) return false;" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Name" HeaderText="Name" />
                            <asp:BoundField DataField="Task" HeaderText="Task" />
                            <asp:BoundField DataField="Description" HeaderText="Description" />
                            <asp:BoundField DataField="Assigned_Employee" HeaderText="Assigned Employee" />
                            <asp:BoundField DataField="Date_Assigned" HeaderText="Date Assigned" />
                            <asp:BoundField DataField="Task_Status" HeaderText="Task Status" />
                            <asp:BoundField DataField="Date_Complete" HeaderText="Date Complete" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
