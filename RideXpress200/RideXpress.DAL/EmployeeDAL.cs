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
    public class EmployeeDAL
    {
        private string _connectionString;

        public EmployeeDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<EmployeeViewModel> GetEmployeeInventory()
        {
            string sqlQuery = "SELECT * FROM Employee";
            List<EmployeeViewModel> employees = new List<EmployeeViewModel>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EmployeeViewModel temp = new EmployeeViewModel()
                        {
                            EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Gender = Convert.ToBoolean(reader["Gender"]),
                            BirthDate = reader["BirthDate"].ToString(),
                            JobTitle = reader["JobTitle"].ToString(),
                            StartDate = reader["StartDate"].ToString(),
                            EndDate = reader["EndDate"].ToString()
                        };
                        employees.Add(temp);
                    }
                }
            }
            return employees;
        }

        public EmployeeViewModel GetEmployeeById(int id)
        {
            EmployeeViewModel employee = new EmployeeViewModel();
            string sqlQuery = "SELECT * FROM Employee WHERE EmployeeID=@EmployeeID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = id;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employee.EmployeeID = Convert.ToInt32(reader["EmployeeID"]);
                        employee.FirstName = reader["FirstName"].ToString();
                        employee.LastName = reader["LastName"].ToString();
                        employee.Gender = Convert.ToBoolean(reader["Gender"]);
                        employee.BirthDate = reader["BirthDate"].ToString();
                        employee.JobTitle = reader["JobTitle"].ToString();
                        employee.StartDate = reader["StartDate"].ToString();
                        employee.EndDate = reader["EndDate"].ToString();
                    }
                }
            }
            return employee;
        }

        public int EditEmployee(EmployeeViewModel edit)
        {
            string sqlQuery = "UPDATE Employee SET FirstName=@FirstName, LastName=@LastName, Gender=@Gender, BirthDate=@BirthDate, JobTitle=@JobTitle, " +
                "StartDate=@StartDate, EndDate=@EndDate WHERE EmployeeID=@EmployeeID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = edit.EmployeeID;
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = edit.FirstName;
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = edit.LastName;
                cmd.Parameters.Add("@Gender", SqlDbType.Bit).Value = edit.Gender;
                cmd.Parameters.Add("@BirthDate", SqlDbType.VarChar).Value = edit.BirthDate;
                cmd.Parameters.Add("@JobTitle", SqlDbType.VarChar).Value = edit.JobTitle;
                cmd.Parameters.Add("@StartDate", SqlDbType.VarChar).Value = edit.StartDate;
                cmd.Parameters.Add("@EndDate", SqlDbType.VarChar).Value = edit.EndDate;
                return cmd.ExecuteNonQuery();
            }
        }

        public int AddEmployee(EmployeeViewModel add)
        {
            string sqlQuery = "INSERT INTO Employee (FirstName, LastName, Gender, BirthDate, JobTitle, StartDate, EndDate) " +
                "VALUES (@FirstName, @LastName, @Gender, @BirthDate, @JobTitle, @StartDate, @EndDate)";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = add.EmployeeID;
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = add.FirstName;
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = add.LastName;
                cmd.Parameters.Add("@Gender", SqlDbType.Bit).Value = add.Gender;
                cmd.Parameters.Add("@BirthDate", SqlDbType.VarChar).Value = add.BirthDate;
                cmd.Parameters.Add("@JobTitle", SqlDbType.VarChar).Value = add.JobTitle;
                cmd.Parameters.Add("@StartDate", SqlDbType.VarChar).Value = add.StartDate;
                cmd.Parameters.Add("@EndDate", SqlDbType.VarChar).Value = add.EndDate;
                return cmd.ExecuteNonQuery();
            }
        }

        public int DeleteEmployee(int id)
        {
            string sqlQuery = "DELETE FROM Employee WHERE EmployeeID=@EmployeeID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = id;
                return cmd.ExecuteNonQuery();
            }
        }

        //Add this for testing
        public int UpdateEmployeeEndDate(int id, string EmployeeEndDate)
        {
            string sqlQuery = "UPDATE Employee SET EndDate=@EndDate WHERE EmployeeID=@EmployeeID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@EndDate", SqlDbType.VarChar).Value = EmployeeEndDate;
                return cmd.ExecuteNonQuery();
            }
        }

        public List<EmployeeViewModel> GetCurrentEmployeeInventory()
        {
            string sqlQuery = "SELECT * FROM Employee WHERE EndDate IS NULL";
            List<EmployeeViewModel> employees = new List<EmployeeViewModel>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EmployeeViewModel temp = new EmployeeViewModel()
                        {
                            EmployeeID = Convert.ToInt32(reader["EmployeeID"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Gender = Convert.ToBoolean(reader["Gender"]),
                            BirthDate = reader["BirthDate"].ToString(),
                            JobTitle = reader["JobTitle"].ToString(),
                            StartDate = reader["StartDate"].ToString(),
                            EndDate = reader["EndDate"].ToString()
                        };
                        employees.Add(temp);
                    }
                }
            }
            return employees;
        }












    }
}
