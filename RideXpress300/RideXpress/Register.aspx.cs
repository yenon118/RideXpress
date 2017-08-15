using RideXpress.BLL;
using RideXpress.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideXpress_StarterKit
{
    public partial class Register : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["RideXpressConnectionString"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            BirthDateValidator.MinimumValue = (DateTime.Now.Date.AddYears(-100)).ToShortDateString();
            BirthDateValidator.MaximumValue = (DateTime.Now.Date.AddYears(100)).ToShortDateString();

            LicenseExpirationDateValidator.MinimumValue = (DateTime.Now.Date.AddYears(-100)).ToShortDateString();
            LicenseExpirationDateValidator.MaximumValue = (DateTime.Now.Date.AddYears(100)).ToShortDateString();

            if (!IsPostBack)
            {

            }
        }

        protected void RegisterSubmitButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["RideXpressConnectionString"].ToString();
                RegistrationBLL bll = new RegistrationBLL(connectionString);
                RegistrationViewModel registration = new RegistrationViewModel();
                registration.Username = Username.Text;
                registration.Email = Email.Text;
                registration.Password = InputPassword.Text;
                registration.FirstName = FirstName.Text;
                registration.LastName = LastName.Text;
                registration.Address = Address.Text;
                registration.City = City.Text;
                registration.State = State.Text;
                registration.ZipCode = Convert.ToInt32(ZipCode.Text);
                registration.DriversLicense = DriversLicense.Text;
                registration.BirthDate = BirthDate.Text;
                registration.LicenseExpirationDate = LicenseExpirationDate.Text;
                registration.LicenseIssuedState = LicenseIssuedState.Text;
                bll.AddRegistration(registration);
                Response.Redirect("~/Index.aspx");
            }
        }





    }
}