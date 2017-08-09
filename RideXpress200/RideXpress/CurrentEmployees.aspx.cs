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
    public partial class CurrentEmployees : System.Web.UI.Page
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

        protected void TerminateEmployeeSubmitButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int id;
                string EmployeeEndDate = "";
                EmployeeBLL bll = new EmployeeBLL(connectionString);
                List<EmployeeViewModel> Terminate_Employee = bll.GetCurrentEmployeeInventory();

                int i;
                for (i = 0; i < Terminate_Employee.Count; i++)
                {
                    if (Terminate_Employee[i].Name.Equals(TerminateEmployeeList.SelectedItem.Text))
                    {
                        break;
                    }
                }

                id = Terminate_Employee[i].EmployeeID;
                EmployeeEndDate = TerminateEmployeeEndDate.Text;

                bll.UpdateEmployeeEndDate(id, EmployeeEndDate);

                Terminate_Employee.Clear();
                Terminate_Employee = bll.GetCurrentEmployeeInventory();
                BindData();
                Response.Redirect("~/CurrentEmployees.aspx");

            }

        }

        protected void EmployeeList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int EmployeeID = Convert.ToInt32(EmployeeList.DataKeys[e.RowIndex].Value.ToString());
            EmployeeBLL EmployeeBL = new EmployeeBLL(connectionString);
            EmployeeBL.DeleteEmployee(EmployeeID);
            BindData();
            Response.Redirect("~/CurrentEmployees.aspx");
        }

        private void BindData()
        {
            EmployeeBLL EmployeeBL = new EmployeeBLL(connectionString);
            List<EmployeeViewModel> employees = EmployeeBL.GetCurrentEmployeeInventory();
            string[] date_notime = new string[3];
            List<string> employees_in_modal = new List<string>();

            /*
            for (int i = 0; i < employees.Count; i++)
            {
                if (!String.IsNullOrEmpty(employees[i].EndDate))
                    employees.RemoveAt(i);
            }
            */

            foreach (EmployeeViewModel element in employees)
            {
                date_notime = element.BirthDate.Split(' ');
                element.BirthDate = date_notime[0];
                date_notime = element.StartDate.Split(' ');
                element.StartDate = date_notime[0];
                if (!String.IsNullOrEmpty(element.EndDate))
                {
                    date_notime = element.EndDate.Split(' ');
                    element.EndDate = date_notime[0];
                }
                employees_in_modal.Add(element.Name);
            }

            TerminateEmployeeList.DataSource = employees_in_modal;
            TerminateEmployeeList.DataBind();

            EmployeeList.DataSource = employees;
            EmployeeList.DataBind();

        }

    }
}