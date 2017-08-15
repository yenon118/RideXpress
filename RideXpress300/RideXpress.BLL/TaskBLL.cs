using RideXpress.DAL;
using RideXpress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideXpress.BLL
{
    public class TaskBLL
    {
        private TaskDAL data;

        public TaskBLL(string connectionString)
        {
            data = new TaskDAL(connectionString);
        }

        public List<TaskViewModel> GetTaskInventory()
        {
            List<TaskViewModel> tasks = new List<TaskViewModel>();
            foreach (TaskViewModel model in data.GetTaskInventory())
            {
                tasks.Add(model);
            }
            return tasks;
        }

        public TaskViewModel GetTaskById(int id)
        {
            return data.GetTaskById(id);
        }

        public int EditTask(TaskViewModel edit)
        {
            return data.EditTask(edit);
        }

        public int AddTask(TaskViewModel add)
        {
            return data.AddTask(add);
        }

        public int DeleteTask(int id)
        {
            return data.DeleteTask(id);
        }

        //Add this for testing
        public Dictionary<int, string> GetNameListFromCarTable()
        {
            return data.GetNameListFromCarTable();
        }

        public Dictionary<int, string> GetNameListFromEmployeeTable()
        {
            return data.GetNameListFromEmployeeTable();
        }

        public int UpdateTask(TaskViewModel update)
        {
            return data.UpdateTask(update);
        }







    }
}
