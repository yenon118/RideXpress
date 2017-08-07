<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/RideXpress.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="RideXpress_StarterKit.Cars" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">
            <div class="row">
                <div class="col-xs-10">
                    <h1>Rides List</h1>
                </div>
                <div class="col-xs-2">
                    <a href="~/AddCar.aspx" runat="server" class="btn btn-success">Add New Ride</a>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12 text-center">
                    <asp:GridView ID="CarList" runat="server" CssClass="table table-bordered text-left"
                        AutoGenerateColumns="False" OnRowDeleting="CarList_RowDeleting" DataKeyNames="CarID">
                        <Columns>
                            <asp:HyperLinkField Text="Edit" DataNavigateUrlFields="CarID"
                                DataNavigateUrlFormatString="~/EditCar.aspx?CarID={0}" ControlStyle-CssClass="btn btn-success btn-xs"
                                ItemStyle-CssClass="text-center" />
                            <asp:TemplateField ItemStyle-CssClass="text-center">
                                <ItemTemplate>
                                    <asp:Button runat="server" ID="DeleteButton" CommandName="Delete"
                                        CssClass="btn btn-xs btn-default" Text="Delete"
                                        OnClientClick="if(!confirm('Are you sure you wish to delete this Ride?')) return false;" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="Name" HeaderText="Name" />
                            <asp:BoundField DataField="Year" HeaderText="Year" />
                            <asp:BoundField DataField="Make" HeaderText="Make" />
                            <asp:BoundField DataField="Model" HeaderText="Model" />
                            <asp:BoundField DataField="Trim" HeaderText="Trim" />
                            <asp:BoundField DataField="Description" HeaderText="Description" />
                            <asp:BoundField DataField="AutomaticDisplay" HeaderText="Transmission" />
                            <asp:BoundField DataField="CityMPG" HeaderText="City MPG" />
                            <asp:BoundField DataField="HighwayMPG" HeaderText="Highway MPG" />
                            <asp:BoundField DataField="HourlyRate" HeaderText="Hourly Rate" HtmlEncode="false" DataFormatString="{0:C}" />
                            <asp:BoundField DataField="DailyRate" HeaderText="Daily Rate" HtmlEncode="false" DataFormatString="{0:C}" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
