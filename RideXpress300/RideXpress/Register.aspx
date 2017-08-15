<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/RideXpress.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RideXpress_StarterKit.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="first">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h1>Registeration</h1>
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
                    <asp:Label ID="EmailLabel" runat="server" Text="Email"
                        AssociatedControlID="Email" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="Email" runat="server" CssClass="form-control" MaxLength="100" TextMode="SingleLine"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ErrorMessage="Email is Required"
                                    ControlToValidate="Email" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
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
                    <asp:Label ID="ConfirmInputPasswordLabel" runat="server" Text="Confirm Password"
                        AssociatedControlID="ConfirmInputPassword" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="ConfirmInputPassword" runat="server" CssClass="form-control" MaxLength="100" TextMode="Password"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="ConfirmInputPasswordRequired" runat="server" ErrorMessage="Password Confirmation is Required"
                                    ControlToValidate="ConfirmInputPassword" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <br />
                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="FirstNameLabel" runat="server" Text="First Name"
                        AssociatedControlID="FirstName" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:TextBox ID="FirstName" runat="server" CssClass="form-control" MaxLength="50" TextMode="SingleLine"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <!--Validation Controls go here-->
                                <asp:RequiredFieldValidator ID="FirstNameRequired" runat="server" ErrorMessage="First Name is Required"
                                    ControlToValidate="FirstName" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="LastNameLabel" runat="server" Text="Last Name"
                        AssociatedControlID="LastName" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:TextBox ID="LastName" runat="server" CssClass="form-control" MaxLength="50" TextMode="SingleLine"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <!--Validation Controls go here-->
                                <asp:RequiredFieldValidator ID="LastNameRequired" runat="server" ErrorMessage="Last Name is Required"
                                    ControlToValidate="LastName" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="AddressLabel" runat="server" Text="Address"
                        AssociatedControlID="Address" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:TextBox ID="Address" runat="server" CssClass="form-control" MaxLength="100" TextMode="SingleLine"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <!--Validation Controls go here-->
                                <asp:RequiredFieldValidator ID="AddressRequired" runat="server" ErrorMessage="Address is Required"
                                    ControlToValidate="Address" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="CityLabel" runat="server" Text="City"
                        AssociatedControlID="City" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:TextBox ID="City" runat="server" CssClass="form-control" MaxLength="50" TextMode="SingleLine"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <!--Validation Controls go here-->
                                <asp:RequiredFieldValidator ID="CityRequired" runat="server" ErrorMessage="City is Required"
                                    ControlToValidate="City" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="StateLabel" runat="server" Text="State"
                        AssociatedControlID="State" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:DropDownList ID="State" runat="server" CssClass="form-control">
                            <asp:ListItem Value="-1">--Select--</asp:ListItem>
                            <asp:ListItem Value="AL">Alabama (AL)</asp:ListItem>
                            <asp:ListItem Value="AK">Alaska (AK)</asp:ListItem>
                            <asp:ListItem Value="AZ">Arizona (AZ)</asp:ListItem>
                            <asp:ListItem Value="AR">Arkansas (AR)</asp:ListItem>
                            <asp:ListItem Value="CA">California (CA)</asp:ListItem>
                            <asp:ListItem Value="CO">Colorado (CO)</asp:ListItem>
                            <asp:ListItem Value="CT">Connecticut (CT)</asp:ListItem>
                            <asp:ListItem Value="DE">Delaware (DE)</asp:ListItem>
                            <asp:ListItem Value="DC">District Of Columbia (DC)</asp:ListItem>
                            <asp:ListItem Value="FL">Florida (FL)</asp:ListItem>
                            <asp:ListItem Value="GA">Georgia (GA)</asp:ListItem>
                            <asp:ListItem Value="HI">Hawaii (HI)</asp:ListItem>
                            <asp:ListItem Value="ID">Idaho (ID)</asp:ListItem>
                            <asp:ListItem Value="IL">Illinois (IL)</asp:ListItem>
                            <asp:ListItem Value="IN">Indiana (IN)</asp:ListItem>
                            <asp:ListItem Value="IA">Iowa (IA)</asp:ListItem>
                            <asp:ListItem Value="KS">Kansas (KS)</asp:ListItem>
                            <asp:ListItem Value="KY">Kentucky (KY)</asp:ListItem>
                            <asp:ListItem Value="LA">Louisiana (LA)</asp:ListItem>
                            <asp:ListItem Value="ME">Maine (ME)</asp:ListItem>
                            <asp:ListItem Value="MD">Maryland (MD)</asp:ListItem>
                            <asp:ListItem Value="MA">Massachusetts (MA)</asp:ListItem>
                            <asp:ListItem Value="MI">Michigan (MI)</asp:ListItem>
                            <asp:ListItem Value="MN">Minnesota (MN)</asp:ListItem>
                            <asp:ListItem Value="MS">Mississippi (MS)</asp:ListItem>
                            <asp:ListItem Value="MO">Missouri (MO)</asp:ListItem>
                            <asp:ListItem Value="MT">Montana (MT)</asp:ListItem>
                            <asp:ListItem Value="NE">Nebraska (NE)</asp:ListItem>
                            <asp:ListItem Value="NV">Nevada (NV)</asp:ListItem>
                            <asp:ListItem Value="NH">New Hampshire (NH)</asp:ListItem>
                            <asp:ListItem Value="NJ">New Jersey (NJ)</asp:ListItem>
                            <asp:ListItem Value="NM">New Mexico (NM)</asp:ListItem>
                            <asp:ListItem Value="NY">New York (NY)</asp:ListItem>
                            <asp:ListItem Value="NC">North Carolina (NC)</asp:ListItem>
                            <asp:ListItem Value="ND">North Dakota (ND)</asp:ListItem>
                            <asp:ListItem Value="OH">Ohio (OH)</asp:ListItem>
                            <asp:ListItem Value="OK">Oklahoma (OK)</asp:ListItem>
                            <asp:ListItem Value="OR">Oregon (OR)</asp:ListItem>
                            <asp:ListItem Value="PA">Pennsylvania (PA)</asp:ListItem>
                            <asp:ListItem Value="RI">Rhode Island (RI)</asp:ListItem>
                            <asp:ListItem Value="SC">South Carolina (SC)</asp:ListItem>
                            <asp:ListItem Value="SD">South Dakota (SD)</asp:ListItem>
                            <asp:ListItem Value="TN">Tennessee (TN)</asp:ListItem>
                            <asp:ListItem Value="TX">Texas (TX)</asp:ListItem>
                            <asp:ListItem Value="UT">Utah (UT)</asp:ListItem>
                            <asp:ListItem Value="VT">Vermont (VT)</asp:ListItem>
                            <asp:ListItem Value="VA">Virginia (VA)</asp:ListItem>
                            <asp:ListItem Value="WA">Washington (WA)</asp:ListItem>
                            <asp:ListItem Value="WV">West Virginia (WV)</asp:ListItem>
                            <asp:ListItem Value="WI">Wisconsin (WI)</asp:ListItem>
                            <asp:ListItem Value="WY">Wyoming (WY)</asp:ListItem>
                            <asp:ListItem Value="AS">American Samoa (AS)</asp:ListItem>
                            <asp:ListItem Value="GU">Guam (GU)</asp:ListItem>
                            <asp:ListItem Value="MP">Northern Mariana Islands (MP)</asp:ListItem>
                            <asp:ListItem Value="PR">Puerto Rico (PR)</asp:ListItem>
                            <asp:ListItem Value="UM">United States Minor Outlying Islands (UM)</asp:ListItem>
                            <asp:ListItem Value="VI">Virgin Islands (VI)</asp:ListItem>
                        </asp:DropDownList>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="StateRequired" runat="server" ErrorMessage="State is Required" InitialValue="-1"
                                    ControlToValidate="State" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="ZipCodeLabel" runat="server" Text="Zip Code"
                        AssociatedControlID="ZipCode" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:TextBox ID="ZipCode" runat="server" CssClass="form-control" MaxLength="5" TextMode="Number"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="ZipCodeRequired" runat="server" ErrorMessage="Zip Code is Required"
                                    ControlToValidate="ZipCode" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="DriversLicenseLabel" runat="server" Text="Driver's License"
                        AssociatedControlID="DriversLicense" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:TextBox ID="DriversLicense" runat="server" CssClass="form-control" MaxLength="10" TextMode="SingleLine"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                                <!--Validation Controls go here-->
                                <asp:RequiredFieldValidator ID="DriversLicenseRequired" runat="server" ErrorMessage="Driver's License is Required"
                                    ControlToValidate="DriversLicense" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="BirthDateLabel" runat="server" Text="Birth Date"
                        AssociatedControlID="BirthDate" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:TextBox ID="BirthDate" runat="server" CssClass="form-control" MaxLength="50" TextMode="Date"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                            <!--Validation Controls go here-->
                            <asp:RequiredFieldValidator ID="BirthDateRequired" runat="server" ErrorMessage="Birth Date is Required" 
                                ControlToValidate="BirthDate" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="BirthDateValidator" runat="server" ControlToValidate="BirthDate" Display="Dynamic"
                                ValidationGroup="AllValidators" ErrorMessage="Please enter a valid Birth Date." Type="Date"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <!--ASP.NET Label Control goes here-->
                    <asp:Label ID="LicenseExpirationDateLabel" runat="server" Text="License Expiration Date"
                        AssociatedControlID="LicenseExpirationDate" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <!--ASP.NET Server Control goes here (TextBox, DropDownList, etc.)-->
                        <asp:TextBox ID="LicenseExpirationDate" runat="server" CssClass="form-control" MaxLength="50" TextMode="Date"></asp:TextBox>
                        <div class="has-error">
                            <span class="help-block">
                            <!--Validation Controls go here-->
                            <asp:RequiredFieldValidator ID="LicenseExpirationDateRequired" runat="server" ErrorMessage="License Expiration Date is Required" 
                                ControlToValidate="LicenseExpirationDate" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="LicenseExpirationDateValidator" runat="server" ControlToValidate="LicenseExpirationDate" Display="Dynamic"
                                ValidationGroup="AllValidators" ErrorMessage="Please enter a valid License Expiration Date." Type="Date"></asp:RangeValidator>
                            </span>
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="LicenseIssuedStateLabel" runat="server" Text="License Issued State"
                        AssociatedControlID="LicenseIssuedState" CssClass="col-xs-4 control-label"></asp:Label>
                    <div class="col-xs-4">
                        <asp:DropDownList ID="LicenseIssuedState" runat="server" CssClass="form-control">
                            <asp:ListItem Value="-1">--Select--</asp:ListItem>
                            <asp:ListItem Value="AL">Alabama (AL)</asp:ListItem>
                            <asp:ListItem Value="AK">Alaska (AK)</asp:ListItem>
                            <asp:ListItem Value="AZ">Arizona (AZ)</asp:ListItem>
                            <asp:ListItem Value="AR">Arkansas (AR)</asp:ListItem>
                            <asp:ListItem Value="CA">California (CA)</asp:ListItem>
                            <asp:ListItem Value="CO">Colorado (CO)</asp:ListItem>
                            <asp:ListItem Value="CT">Connecticut (CT)</asp:ListItem>
                            <asp:ListItem Value="DE">Delaware (DE)</asp:ListItem>
                            <asp:ListItem Value="DC">District Of Columbia (DC)</asp:ListItem>
                            <asp:ListItem Value="FL">Florida (FL)</asp:ListItem>
                            <asp:ListItem Value="GA">Georgia (GA)</asp:ListItem>
                            <asp:ListItem Value="HI">Hawaii (HI)</asp:ListItem>
                            <asp:ListItem Value="ID">Idaho (ID)</asp:ListItem>
                            <asp:ListItem Value="IL">Illinois (IL)</asp:ListItem>
                            <asp:ListItem Value="IN">Indiana (IN)</asp:ListItem>
                            <asp:ListItem Value="IA">Iowa (IA)</asp:ListItem>
                            <asp:ListItem Value="KS">Kansas (KS)</asp:ListItem>
                            <asp:ListItem Value="KY">Kentucky (KY)</asp:ListItem>
                            <asp:ListItem Value="LA">Louisiana (LA)</asp:ListItem>
                            <asp:ListItem Value="ME">Maine (ME)</asp:ListItem>
                            <asp:ListItem Value="MD">Maryland (MD)</asp:ListItem>
                            <asp:ListItem Value="MA">Massachusetts (MA)</asp:ListItem>
                            <asp:ListItem Value="MI">Michigan (MI)</asp:ListItem>
                            <asp:ListItem Value="MN">Minnesota (MN)</asp:ListItem>
                            <asp:ListItem Value="MS">Mississippi (MS)</asp:ListItem>
                            <asp:ListItem Value="MO">Missouri (MO)</asp:ListItem>
                            <asp:ListItem Value="MT">Montana (MT)</asp:ListItem>
                            <asp:ListItem Value="NE">Nebraska (NE)</asp:ListItem>
                            <asp:ListItem Value="NV">Nevada (NV)</asp:ListItem>
                            <asp:ListItem Value="NH">New Hampshire (NH)</asp:ListItem>
                            <asp:ListItem Value="NJ">New Jersey (NJ)</asp:ListItem>
                            <asp:ListItem Value="NM">New Mexico (NM)</asp:ListItem>
                            <asp:ListItem Value="NY">New York (NY)</asp:ListItem>
                            <asp:ListItem Value="NC">North Carolina (NC)</asp:ListItem>
                            <asp:ListItem Value="ND">North Dakota (ND)</asp:ListItem>
                            <asp:ListItem Value="OH">Ohio (OH)</asp:ListItem>
                            <asp:ListItem Value="OK">Oklahoma (OK)</asp:ListItem>
                            <asp:ListItem Value="OR">Oregon (OR)</asp:ListItem>
                            <asp:ListItem Value="PA">Pennsylvania (PA)</asp:ListItem>
                            <asp:ListItem Value="RI">Rhode Island (RI)</asp:ListItem>
                            <asp:ListItem Value="SC">South Carolina (SC)</asp:ListItem>
                            <asp:ListItem Value="SD">South Dakota (SD)</asp:ListItem>
                            <asp:ListItem Value="TN">Tennessee (TN)</asp:ListItem>
                            <asp:ListItem Value="TX">Texas (TX)</asp:ListItem>
                            <asp:ListItem Value="UT">Utah (UT)</asp:ListItem>
                            <asp:ListItem Value="VT">Vermont (VT)</asp:ListItem>
                            <asp:ListItem Value="VA">Virginia (VA)</asp:ListItem>
                            <asp:ListItem Value="WA">Washington (WA)</asp:ListItem>
                            <asp:ListItem Value="WV">West Virginia (WV)</asp:ListItem>
                            <asp:ListItem Value="WI">Wisconsin (WI)</asp:ListItem>
                            <asp:ListItem Value="WY">Wyoming (WY)</asp:ListItem>
                            <asp:ListItem Value="AS">American Samoa (AS)</asp:ListItem>
                            <asp:ListItem Value="GU">Guam (GU)</asp:ListItem>
                            <asp:ListItem Value="MP">Northern Mariana Islands (MP)</asp:ListItem>
                            <asp:ListItem Value="PR">Puerto Rico (PR)</asp:ListItem>
                            <asp:ListItem Value="UM">United States Minor Outlying Islands (UM)</asp:ListItem>
                            <asp:ListItem Value="VI">Virgin Islands (VI)</asp:ListItem>
                        </asp:DropDownList>
                        <div class="has-error">
                            <span class="help-block">
                                <asp:RequiredFieldValidator ID="LicenseIssuedStateRequired" runat="server" ErrorMessage="License Issued State is Required" InitialValue="-1"
                                    ControlToValidate="LicenseIssuedState" Display="Dynamic" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                            </span>
                        </div>
                    </div>
                </div>


                <div class="form-group">
                    <div class="col-xs-4 col-xs-offset-4">
                        <asp:Button ID="RegisterSubmitButton" runat="server" Text="Register" CssClass="btn btn-success"
                            OnClick="RegisterSubmitButton_Click" ValidationGroup="AllValidators" />
                        <asp:HyperLink CssClass="btn btn-default" NavigateUrl="~/Index.aspx" runat="server" Text="Cancel" />
                    </div>
                </div>

            </div>
        </div>
    </section>

</asp:Content>
