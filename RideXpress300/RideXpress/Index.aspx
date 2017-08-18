<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/RideXpress.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="RideXpress_StarterKit.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="mainCarousel" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators">
            <li data-target="#mainCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#mainCarousel" data-slide-to="1"></li>
            <li data-target="#mainCarousel" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner" role="listbox">
            <div class="item active">
                <img src="Images/350zWheel.jpg" alt="Gym Image 1" />
                <div class="carousel-caption">
                    <h1 class="title">RideXpress</h1>
                    <h1>The Xpressway To Your Ride</h1>
                </div>
            </div>
            <div class="item">
                <img src="Images/BMWWhiteFront.jpg" alt="Gym Image 2" />
                <div class="carousel-caption">
                    <h1>View & Manage Every Ride Available.</h1>
                    <p>Instant access to all of your Rides, with a click of a button!</p>
                    <p>
                        <asp:Button ID="Cars_aspx_Button" runat="server" Text="Go To Rides List"  CssClass="btn btn-lg btn-success" OnClick="CarsaspxButton_Click" ValidationGroup="AllValidators"/>
                    </p>
                </div>
            </div>
            <div class="item">
                <img src="Images/Traffic.jpg" alt="Weight Image 1" />
                <div class="carousel-caption">
                    <h1>Have an Issue with Your Ride?</h1>
                    <p>Maintain Information About Your Employees Manage Employees.</p>
                    <p>
                        <asp:Button ID="CurrentEmployees_aspx_Button" runat="server" Text="Manage Employees"  CssClass="btn btn-lg btn-success" OnClick="CurrentEmployeesaspxButton_Click" ValidationGroup="AllValidators"/>
                    </p>
                </div>
            </div>
        </div>
        <a class="left carousel-control" href="#mainCarousel" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#mainCarousel" role="button" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>
    <section class="success">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h2>View & Manage Every Ride Available.</h2>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-8 col-xs-offset-2 text-center">
                    <p>
                        Instant access to all of your Rides, with a click of a button!
                    </p>
                </div>
                <div class="col-xs-8 col-xs-offset-2 text-center">
                    <br />
                    <asp:Button ID="Cars_aspx_Button1" runat="server" Text="Go To Rides List"  CssClass="btn btn-lg btn-outline" OnClick="CarsaspxButton_Click" ValidationGroup="AllValidators"/>
                </div>
            </div>
        </div>
    </section>
    <section>
        <div class="container">
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h2>Have an Issue with Your Ride?</h2>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-8 col-xs-offset-2 text-center">
                    <p>Maintain Information About Your Employees.</p>
                </div>
                <div class="col-xs-8 col-xs-offset-2 text-center">
                    <br />
                    <asp:Button ID="CurrentEmployees_aspx_Button1" runat="server" Text="Manage Employees"  CssClass="btn btn-lg btn-success" OnClick="CurrentEmployeesaspxButton_Click" ValidationGroup="AllValidators"/>
                </div>
            </div>
        </div>
    </section>
    <section class="success">
        <div class="container">
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h2>Do you need to schedule a ride with us?</h2>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-8 col-xs-offset-2 text-center">
                    <p>Manage ride scheduling and tasks.</p>
                </div>
                <div class="col-xs-8 col-xs-offset-2 text-center">
                    <br />
                    <asp:Button ID="Tasks_aspx_Button1" runat="server" Text="Manage Tasks"  CssClass="btn btn-lg btn-outline" OnClick="TasksaspxButton_Click" ValidationGroup="AllValidators"/>
                </div>
            </div>
        </div>
    </section>
    <section>
        <div class="container">
            <div class="row">
                <div class="col-xs-12 text-center">
                    <h2>Want to know more about us?</h2>
                </div>
            </div>
            <div class="row">
                <div class="col-xs-8 col-xs-offset-2 text-center">
                    <br />
                    <a href="~/About.aspx" runat="server" class="btn btn-lg btn-success">About</a>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
