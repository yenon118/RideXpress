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
    public partial class EditTask : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["RideXpressConnectionString"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();

                TaskBLL bll = new TaskBLL(connectionString);
                TaskViewModel task = bll.GetTaskById(Convert.ToInt32(Request.QueryString["TaskID"]));

                SelectCar.Text = task.Name;
                TaskTitle.Text = task.TaskTitle;
                TaskDescription.Text = task.TaskDescription;
                AssignedEmployee.Text = task.EmployeeName;

            }
        }

        protected void TaskEditButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                TaskBLL blll = new TaskBLL(connectionString);
                TaskViewModel taski = new TaskViewModel();
                Dictionary<int, string> CarID_Name = blll.GetNameListFromCarTable();
                Dictionary<int, string> EmployeeID_Name = blll.GetNameListFromEmployeeTable();

                taski.TaskID = Convert.ToInt32(Request.QueryString["TaskID"]);

                taski.CarID = CarID_Name.FirstOrDefault(x => x.Value == SelectCar.SelectedItem.Text).Key;
                taski.EmployeeID = EmployeeID_Name.FirstOrDefault(x => x.Value == AssignedEmployee.SelectedItem.Text).Key;

                taski.TaskTitle = TaskTitle.Text;
                taski.TaskDescription = TaskDescription.Text;

                blll.EditTask(taski);
                Response.Redirect("~/Tasks.aspx");
            }
        }

        private void BindData()
        {
            TaskBLL TaskBL = new TaskBLL(connectionString);
            Dictionary<int, string> CarID_Name = TaskBL.GetNameListFromCarTable();
            Dictionary<int, string> EmployeeID_Name = TaskBL.GetNameListFromEmployeeTable();

            SelectCar.DataSource = CarID_Name.Values;
            SelectCar.DataBind();

            AssignedEmployee.DataSource = EmployeeID_Name.Values;
            AssignedEmployee.DataBind();
        }




    }
}