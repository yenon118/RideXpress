using RideXpress.BLL;
using RideXpress.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideXpress_StarterKit
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void LoginSubmitButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["RideXpressConnectionString"].ToString();
                RegistrationBLL bll = new RegistrationBLL(connectionString);
                RegistrationViewModel login = bll.GetRegistrationByUsername(Username.Text);
                if (InputPassword.Text.Equals(login.Password))
                {
                    FormsAuthentication.RedirectFromLoginPage(Username.Text, false);
                    //Response.Redirect("~/Cars.aspx");
                }
                else
                {
                    Username.Text = string.Empty;
                    InputPassword.Text = string.Empty;
                    InvalidLoginText.Text = "Invalid Username or Password";
                    //Response.Redirect("~/Login.aspx");
                }
            }
        }





    }
}