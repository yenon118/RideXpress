using RideXpress.BLL;
using RideXpress.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace RideXpress_StarterKit
{
    public partial class AddEmployee : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeBirthDateValidator.MinimumValue = (DateTime.Now.Date.AddYears(-100)).ToShortDateString();
            EmployeeBirthDateValidator.MaximumValue = (DateTime.Now.Date.AddYears(100)).ToShortDateString();

            EmployeeStartDateValidator.MinimumValue = (DateTime.Now.Date.AddYears(-100)).ToShortDateString();
            EmployeeStartDateValidator.MaximumValue = (DateTime.Now.Date.AddYears(100)).ToShortDateString();

            if (!IsPostBack)
            {
                //BindData();
            }
        }

        protected void EmployeeAddButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["RideXpressConnectionString"].ToString();
                EmployeeBLL bll = new EmployeeBLL(connectionString);
                EmployeeViewModel employee = new EmployeeViewModel();
                employee.FirstName = EmployeeFirstName.Text;
                employee.LastName = EmployeeLastName.Text;
                employee.Gender = Convert.ToBoolean(EmployeeGender.SelectedValue);
                employee.BirthDate = EmployeeBirthDate.Text;
                employee.JobTitle = EmployeeJobTitle.Text;
                employee.StartDate = EmployeeStartDate.Text;
                employee.EndDate = null;
                bll.AddEmployee(employee);
                Response.Redirect("~/CurrentEmployees.aspx");
            }
        }






    }
}