<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/RideXpress.Master" AutoEventWireup="true" CodeBehind="EditCar.aspx.cs" Inherits="RideXpress_StarterKit.EditCar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h1>Add Ride</h1>
                </div>
            </div>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label ID="NameLabel" runat="server" Text="Name"
                        AssociatedControlID="Name" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Name" runat="server" CssClass="form-control" MaxLength="100" TextMode="SingleLine"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="NameRequired" runat="server" ErrorMessage="Name is Required"
                                    ControlToValidate="Name" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="YearLabel" runat="server" Text="Year"
                        AssociatedControlID="Year" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Year" runat="server" CssClass="form-control" MaxLength="4" TextMode="Number"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="YearRequired" runat="server" ErrorMessage="Year is Required"
                                    ControlToValidate="Year" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="YearValidator" runat="server" ControlToValidate="Year" Display="Dynamic"
                                    ValidationGroup="AllValidators" MinimumValue="1980"
                                    ErrorMessage="Please enter a valid Year" Type="Integer"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="MakeLabel" runat="server" Text="Make"
                        AssociatedControlID="Make" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Make" runat="server" CssClass="form-control" MaxLength="50" TextMode="SingleLine"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="MakeRequired" runat="server" ErrorMessage="Make is Required"
                                    ControlToValidate="Make" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="ModelLabel" runat="server" Text="Model"
                        AssociatedControlID="Model" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Model" runat="server" CssClass="form-control" MaxLength="50" TextMode="SingleLine"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="ModelRequired" runat="server" ErrorMessage="Model is Required"
                                    ControlToValidate="Model" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="TrimLabel" runat="server" Text="Trim"
                        AssociatedControlID="Trim" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Trim" runat="server" CssClass="form-control" MaxLength="50" TextMode="SingleLine"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="TrimRequired" runat="server" ErrorMessage="Trim is Required"
                                    ControlToValidate="Trim" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="DescriptionLabel" runat="server" Text="Description"
                        AssociatedControlID="Description" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Description" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="5"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="DescriptionRequired" runat="server" ErrorMessage="Description is Required"
                                    ControlToValidate="Description" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="CityMPGLabel" runat="server" Text="City MPG"
                        AssociatedControlID="CityMPG" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="CityMPG" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="CityMPGRequired" runat="server" ErrorMessage="City MPG is Required"
                                    ControlToValidate="CityMPG" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="CityMPGValidator" runat="server" ControlToValidate="CityMPG" Display="Dynamic"
                                    ValidationGroup="AllValidators" MinimumValue="1" MaximumValue="200"
                                    ErrorMessage="Please enter a valid Miles Per Gallon value" Type="Integer"></asp:RangeValidator>

                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="HighwayMPGLabel" runat="server" Text="Highway MPG"
                        AssociatedControlID="HighwayMPG" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="HighwayMPG" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="HighwayMPGRequired" runat="server" ErrorMessage="Highway MPG is Required"
                                    ControlToValidate="HighwayMPG" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="HighwayMPGValidator" runat="server" ControlToValidate="HighwayMPG" Display="Dynamic"
                                    ValidationGroup="AllValidators" MinimumValue="1" MaximumValue="200"
                                    ErrorMessage="Please enter a valid Miles Per Gallon value" Type="Integer"></asp:RangeValidator>
                                <asp:CompareValidator ID="HighwayMPGCompare" ControlToValidate="CityMPG" ControlToCompare="HighwayMPG"
                                    Operator="LessThan" runat="server" ErrorMessage="City MPG must be less than Highway MPG" Type="Integer"
                                    Display="Dynamic" ValidationGroup="AllValidators"></asp:CompareValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="TransmissionLabel" runat="server" Text="Transmission"
                        AssociatedControlID="IsAutomatic" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:DropDownList ID="IsAutomatic" runat="server" CssClass="form-control">
                            <asp:ListItem Value="0">--Select--</asp:ListItem>
                            <asp:ListItem Value="True">Automatic</asp:ListItem>
                            <asp:ListItem Value="False">Manual</asp:ListItem>
                        </asp:DropDownList>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="TransmissionRequired" runat="server" ErrorMessage="Transmission is Required" InitialValue="0"
                                    ControlToValidate="IsAutomatic" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="HourlyRateLabel" runat="server" Text="Hourly Rate"
                        AssociatedControlID="HourlyRate" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="HourlyRate" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="HourlyRateRequired" runat="server" ErrorMessage="Hourly is Required"
                                    ControlToValidate="HourlyRate" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="HourlyRateValidator" runat="server" ControlToValidate="HourlyRate" Display="Dynamic"
                                    ValidationGroup="AllValidators" MinimumValue="1" MaximumValue="999.99"
                                    ErrorMessage="Please enter a valid Hourly Rate (Max: $999.99)" Type="Double"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-xs-4 col-xs-offset-4">
                        <asp:Button ID="CarEditButton" runat="server" Text="Submit" CssClass="btn btn-success"
                            OnClick="CarEditButton_Click" ValidationGroup="AllValidators" />
                        <asp:HyperLink CssClass="btn btn-default" NavigateUrl="~/Cars.aspx" runat="server" Text="Back" />
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
