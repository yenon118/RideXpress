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
    public partial class Tasks : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["RideXpressConnectionString"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        protected void TaskList_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int TaskID = Convert.ToInt32(TaskList.DataKeys[e.NewEditIndex].Value.ToString());
            string edittaskurl = "~/EditTask.aspx?TaskID=" + TaskID.ToString();
            Response.Redirect(edittaskurl);
        }

        protected void TaskList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (Page.IsValid)
            {
                int TaskID = Convert.ToInt32(TaskList.DataKeys[e.RowIndex].Value.ToString());
                TaskBLL TaskBL = new TaskBLL(connectionString);
                TaskBL.DeleteTask(TaskID);
                BindData();
                Response.Redirect("~/Tasks.aspx");
            }
        }

        protected void TaskList_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            if (Page.IsValid)
            {
                TaskBLL bll = new TaskBLL(connectionString);
                TaskViewModel task = bll.GetTaskById(Convert.ToInt32(TaskList.DataKeys[e.RowIndex].Value.ToString()));

                task.DateComplete = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                bll.UpdateTask(task);
                BindData();
                Response.Redirect("~/Tasks.aspx");
                
            }
        }

        protected void TaskList_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.Cells[8].Text.Equals("Completed"))
            {
                e.Row.FindControl("EditButton").Visible = false;
                e.Row.FindControl("MarkCompleteButton").Visible = false;

            }
            else if (e.Row.Cells[8].Text.Equals("Active"))
            {
                e.Row.FindControl("DeleteButton").Visible = false;
            }
        }


        private void BindData()
        {
            TaskBLL TaskBL = new TaskBLL(connectionString);
            List<TaskViewModel> tasks = TaskBL.GetTaskInventory();
            Dictionary<int, string> CarID_Name = TaskBL.GetNameListFromCarTable();
            Dictionary<int, string> EmployeeID_Name = TaskBL.GetNameListFromEmployeeTable();
            string[] date_notime = new string[3];

            foreach (TaskViewModel element in tasks)
            {
                date_notime = element.DateAssigned.Split(' ');
                element.DateAssigned = date_notime[0];

                if (!String.IsNullOrEmpty(element.DateComplete))
                {
                    date_notime = element.DateComplete.Split(' ');
                    element.DateComplete = date_notime[0];
                }
            }

            SelectCar.DataSource = CarID_Name.Values;
            SelectCar.DataBind();

            AssignedEmployee.DataSource = EmployeeID_Name.Values;
            AssignedEmployee.DataBind();

            TaskList.DataSource = tasks;
            TaskList.DataBind();
        }

        protected void AddNewTaskSubmitButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                TaskBLL bll = new TaskBLL(connectionString);
                TaskViewModel task = new TaskViewModel();
                Dictionary<int, string> CarID_Name = bll.GetNameListFromCarTable();
                Dictionary<int, string> EmployeeID_Name = bll.GetNameListFromEmployeeTable();

                task.CarID = CarID_Name.FirstOrDefault(x => x.Value == SelectCar.SelectedItem.Text).Key;
                task.EmployeeID = EmployeeID_Name.FirstOrDefault(x => x.Value == AssignedEmployee.SelectedItem.Text).Key;

                task.TaskTitle = TaskTitle.Text;
                task.TaskDescription = TaskDescription.Text;
                task.DateAssigned = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"); ;

                bll.AddTask(task);
                Response.Redirect("~/Tasks.aspx");
            }
        }







    }
}