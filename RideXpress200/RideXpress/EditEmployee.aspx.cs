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
    public partial class EditEmployee : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["RideXpressConnectionString"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            EmployeeBirthDateValidator.MinimumValue = (DateTime.Now.Date.AddYears(-100)).ToShortDateString();
            EmployeeBirthDateValidator.MaximumValue = (DateTime.Now.Date.AddYears(100)).ToShortDateString();

            EmployeeStartDateValidator.MinimumValue = (DateTime.Now.Date.AddYears(-100)).ToShortDateString();
            EmployeeStartDateValidator.MaximumValue = (DateTime.Now.Date.AddYears(100)).ToShortDateString();

            if (!IsPostBack)
            {
                EmployeeBLL bll = new EmployeeBLL(connectionString);
                EmployeeViewModel employee = bll.GetEmployeeById(Convert.ToInt32(Request.QueryString["EmployeeID"]));
                EmployeeFirstName.Text = employee.FirstName;
                EmployeeLastName.Text = employee.LastName;
                EmployeeGender.SelectedValue = employee.Gender.ToString();
                EmployeeBirthDate.Text = DateTime.ParseExact(MakeCompleteDate(employee.BirthDate), "MM-dd-yyyy hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                EmployeeJobTitle.Text = employee.JobTitle;
                EmployeeStartDate.Text = DateTime.ParseExact(MakeCompleteDate(employee.StartDate), "MM-dd-yyyy hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");

            }
        }

        protected void EmployeeEditButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                
                EmployeeBLL bll = new EmployeeBLL(connectionString);
                EmployeeViewModel employee = new EmployeeViewModel();

                employee.EmployeeID = Convert.ToInt32(Request.QueryString["EmployeeID"]);
                employee.FirstName = EmployeeFirstName.Text;
                employee.LastName = EmployeeLastName.Text;
                employee.Gender = Convert.ToBoolean(EmployeeGender.SelectedValue);
                employee.BirthDate = EmployeeBirthDate.Text;
                employee.JobTitle = EmployeeJobTitle.Text;
                employee.StartDate = EmployeeStartDate.Text;

                bll.EditEmployee(employee);
                Response.Redirect("~/CurrentEmployees.aspx");
                
            }
        }

        private string MakeCompleteDate(string complete_date_time)
        {
            string[] date_element = complete_date_time.Split('/');
            complete_date_time = "";

            for (int i = 0; i < date_element.Length - 1; i++)
            {
                if (date_element[i].Length == 1)
                {
                    date_element[i] = "0" + date_element[i];
                }
            }

            complete_date_time = date_element[0] + "-" + date_element[1] + "-" + date_element[2];
            return complete_date_time;
        }











    }
}