using RideXpress.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideXpress.DAL
{
    public class TaskDAL
    {
        private string _connectionString;

        public TaskDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<TaskViewModel> GetTaskInventory()
        {
            string sqlQuery = "SELECT Task.*, Car.Name, Employee.FirstName, Employee.LastName FROM Task " +
                              "RIGHT OUTER JOIN Car ON Task.CarID = Car.CarID " +
                              "INNER JOIN Employee ON Task.EmployeeID = Employee.EmployeeID";
            List<TaskViewModel> tasks = new List<TaskViewModel>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TaskViewModel temp = new TaskViewModel()
                        {
                            TaskID = Convert.ToInt32(reader["TaskID"]),
                            CarID = Convert.ToInt32(reader["CarID"]),
                            EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                            TaskTitle = reader["TaskTitle"].ToString(),
                            TaskDescription = reader["TaskDescription"].ToString(),
                            DateAssigned = reader["DateAssigned"].ToString(),
                            DateComplete = reader["DateComplete"].ToString(),
                            Name = reader["Name"].ToString(),
                            EmployeeFirstName = reader["FirstName"].ToString(),
                            EmployeeLastName = reader["LastName"].ToString()
                        };
                        tasks.Add(temp);
                    }
                }
            }
            return tasks;
        }

        public TaskViewModel GetTaskById(int id)
        {
            TaskViewModel task = new TaskViewModel();
            string sqlQuery = "SELECT Task.*, Car.Name, Employee.FirstName, Employee.LastName FROM Task " +
                              "RIGHT OUTER JOIN Car ON Task.CarID = Car.CarID " +
                              "INNER JOIN Employee ON Task.EmployeeID = Employee.EmployeeID WHERE TaskID = @TaskID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@TaskID", SqlDbType.Int).Value = id;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        task.TaskID = Convert.ToInt32(reader["TaskID"]);
                        task.CarID = Convert.ToInt32(reader["CarID"]);
                        task.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                        task.TaskTitle = reader["TaskTitle"].ToString();
                        task.TaskDescription = reader["TaskDescription"].ToString();
                        task.DateAssigned = reader["DateAssigned"].ToString();
                        task.DateComplete = reader["DateComplete"].ToString();
                        task.Name = reader["Name"].ToString();
                        task.EmployeeFirstName = reader["FirstName"].ToString();
                        task.EmployeeLastName = reader["LastName"].ToString();
                    }
                }
            }
            return task;
        }


        public int EditTask(TaskViewModel edit)
        {
            string sqlQuery = "UPDATE Task SET CarID=@CarID, EmployeeID=@EmployeeID, TaskTitle=@TaskTitle, " +
                              "TaskDescription=@TaskDescription WHERE TaskID=@TaskID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@TaskID", SqlDbType.Int).Value = edit.TaskID;
                cmd.Parameters.Add("@CarID", SqlDbType.Int).Value = edit.CarID;
                cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = edit.EmployeeID;
                cmd.Parameters.Add("@TaskTitle", SqlDbType.VarChar).Value = edit.TaskTitle;
                cmd.Parameters.Add("@TaskDescription", SqlDbType.VarChar).Value = edit.TaskDescription;
                return cmd.ExecuteNonQuery();
            }
        }

        public int AddTask(TaskViewModel add)
        {
            string sqlQuery = "INSERT INTO Task (CarID, EmployeeID, TaskTitle, TaskDescription, DateAssigned) " +
                "VALUES (@CarID, @EmployeeID, @TaskTitle, @TaskDescription, @DateAssigned)";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@CarID", SqlDbType.Int).Value = add.CarID;
                cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = add.EmployeeID;
                cmd.Parameters.Add("@TaskTitle", SqlDbType.VarChar).Value = add.TaskTitle;
                cmd.Parameters.Add("@TaskDescription", SqlDbType.VarChar).Value = add.TaskDescription;
                cmd.Parameters.Add("@DateAssigned", SqlDbType.VarChar).Value = add.DateAssigned;
                return cmd.ExecuteNonQuery();
            }
        }

        public int DeleteTask(int id)
        {
            string sqlQuery = "DELETE FROM Task WHERE TaskID=@TaskID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@TaskID", SqlDbType.Int).Value = id;
                return cmd.ExecuteNonQuery();
            }
        }

        //Add this for testing
        public Dictionary<int, string> GetNameListFromCarTable()
        {
            string sqlQuery = "SELECT CarID, Name FROM Car";
            Dictionary<int, string> NameListFromCarTable = new Dictionary<int, string>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NameListFromCarTable.Add(Convert.ToInt32(reader["CarID"]), reader["Name"].ToString());
                    }
                }
            }
            return NameListFromCarTable;
        }

        public Dictionary<int, string> GetNameListFromEmployeeTable()
        {
            string sqlQuery = "SELECT EmployeeID, FirstName, LastName FROM Employee WHERE EndDate IS NULL";
            Dictionary<int, string> NameListFromEmployeeTable = new Dictionary<int, string>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NameListFromEmployeeTable.Add(Convert.ToInt32(reader["EmployeeID"]), reader["FirstName"].ToString()+" "+ reader["LastName"].ToString());
                    }
                }
            }
            return NameListFromEmployeeTable;
        }

        public int UpdateTask(TaskViewModel update)
        {
            string sqlQuery = "UPDATE Task SET DateComplete=@DateComplete WHERE TaskID=@TaskID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@TaskID", SqlDbType.Int).Value = update.TaskID;
                cmd.Parameters.Add("@DateComplete", SqlDbType.VarChar).Value = update.DateComplete;
                return cmd.ExecuteNonQuery();
            }
        }







    }
}
