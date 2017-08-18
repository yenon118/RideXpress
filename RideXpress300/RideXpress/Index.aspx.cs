using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideXpress_StarterKit
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CarsaspxButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    Response.Redirect("~/Cars.aspx");
                }
                else
                {
                    Response.Redirect("~/Login.aspx");
                }
            }
        }

        protected void CurrentEmployeesaspxButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    Response.Redirect("~/CurrentEmployees.aspx");
                }
                else
                {
                    Response.Redirect("~/Login.aspx");
                }
            }
        }

        protected void TasksaspxButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    Response.Redirect("~/Tasks.aspx");
                }
                else
                {
                    Response.Redirect("~/Login.aspx");
                }
            }
        }




    }
}