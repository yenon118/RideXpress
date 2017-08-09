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
    public partial class Employees : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["RideXpressConnectionString"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            TerminateEmployeeEndDateValidator.MinimumValue = (DateTime.Now.Date.AddYears(-10)).ToShortDateString();
            TerminateEmployeeEndDateValidator.MaximumValue = (DateTime.Now.Date.AddYears(10)).ToShortDateString();

            if (!IsPostBack)
            {
                BindData();
            }
        }

        protected void TerminateEmployeeCloseButton_Click(object sender, EventArgs e)
        {

        }

        protected void TerminateEmployeeSubmitButton_Click(object sender, EventArgs e)
        {

        }

        protected void EmployeeList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int EmployeeID = Convert.ToInt32(EmployeeList.DataKeys[e.RowIndex].Value.ToString());
            EmployeeBLL EmployeeBL = new EmployeeBLL(connectionString);
            EmployeeBL.DeleteEmployee(EmployeeID);
            BindData();
        }

        private void BindData()
        {
            EmployeeBLL EmployeeBL = new EmployeeBLL(connectionString);
            List<EmployeeViewModel> employees = EmployeeBL.GetEmployeeInventory();
            string[] date_notime = new string[3];
            
            foreach (EmployeeViewModel element in employees)
            {
                date_notime = element.BirthDate.Split(' ');
                element.BirthDate = date_notime[0];
                date_notime = element.StartDate.Split(' ');
                element.StartDate = date_notime[0];
                if(!String.IsNullOrEmpty(element.EndDate))
                {
                    date_notime = element.EndDate.Split(' ');
                    element.EndDate = date_notime[0];
                }
            }

            EmployeeList.DataSource = employees;
            EmployeeList.DataBind();
        }

    }
}