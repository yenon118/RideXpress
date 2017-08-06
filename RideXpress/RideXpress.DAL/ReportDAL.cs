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
    public class ReportDAL
    {
        private string _connectionString;

        public ReportDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<ReportViewModel> GetIncidentReportInventory()
        {
            string sqlQuery = "SELECT * FROM IncidentReport";
            List<ReportViewModel> incident_reports = new List<ReportViewModel>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ReportViewModel temp = new ReportViewModel()
                        {
                            ReportID = Convert.ToInt32(reader["ReportID"]),
                            CarID = Convert.ToInt32(reader["CarID"]),
                            DateOfIncident = reader["DateOfIncident"].ToString(),
                            ReportName = reader["ReportName"].ToString(),
                            ReportDescription = reader["ReportDescription"].ToString(),
                            DateOfReport = reader["DateOfReport"].ToString()
                        };
                        //temp.Name = GetCarNameFromCarID(temp.CarID);    //Yen added this line.
                        incident_reports.Add(temp);
                    }
                }
            }
            return incident_reports;
        }

        public ReportViewModel GetIncidentReportById(int id)
        {
            ReportViewModel incident_report = new ReportViewModel();
            string sqlQuery = "SELECT * FROM IncidentReport WHERE ReportID=@ReportID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@ReportID", SqlDbType.Int).Value = id;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        incident_report.ReportID = Convert.ToInt32(reader["ReportID"]);
                        incident_report.CarID = Convert.ToInt32(reader["CarID"]);
                        //incident_report.Name = GetCarNameFromCarID(incident_report.CarID);  //Yen added this line.
                        incident_report.DateOfIncident = reader["DateOfIncident"].ToString();
                        incident_report.ReportName = reader["ReportName"].ToString();
                        incident_report.ReportDescription = reader["ReportDescription"].ToString();
                        incident_report.DateOfReport = reader["DateOfReport"].ToString();
                    }
                }
            }
            return incident_report;
        }

        public int EditIncidentReport(ReportViewModel edit)
        {
            string sqlQuery = "UPDATE IncidentReport SET CarID=@CarID, DateOfIncident=@DateOfIncident, ReportName=@ReportName, ReportDescription=@ReportDescription, DateOfReport=@DateOfReport, " +
                "WHERE ReportID=@ReportID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@ReportID", SqlDbType.Int).Value = edit.ReportID;
                cmd.Parameters.Add("@CarID", SqlDbType.Int).Value = edit.CarID;
                cmd.Parameters.Add("@DateOfIncident", SqlDbType.VarChar).Value = edit.DateOfIncident;
                cmd.Parameters.Add("@ReportName", SqlDbType.VarChar).Value = edit.ReportName;
                cmd.Parameters.Add("@ReportDescription", SqlDbType.VarChar).Value = edit.ReportDescription;
                cmd.Parameters.Add("@DateOfReport", SqlDbType.VarChar).Value = edit.DateOfReport;
                return cmd.ExecuteNonQuery();
            }
        }

        public int AddIncidentReport(ReportViewModel add)
        {
            string sqlQuery = "INSERT INTO IncidentReport (CarID, DateOfIncident, ReportName, ReportDescription, DateOfReport) " +
                "VALUES (@CarID, @DateOfIncident, @ReportName, @ReportDescription, @DateOfReport)";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@ReportID", SqlDbType.Int).Value = add.ReportID;
                cmd.Parameters.Add("@CarID", SqlDbType.Int).Value = add.CarID;
                cmd.Parameters.Add("@DateOfIncident", SqlDbType.VarChar).Value = add.DateOfIncident;
                cmd.Parameters.Add("@ReportName", SqlDbType.VarChar).Value = add.ReportName;
                cmd.Parameters.Add("@ReportDescription", SqlDbType.VarChar).Value = add.ReportDescription;
                cmd.Parameters.Add("@DateOfReport", SqlDbType.VarChar).Value = add.DateOfReport;
                return cmd.ExecuteNonQuery();
            }
        }

        public int DeleteIncidentReport(int id)
        {
            string sqlQuery = "DELETE FROM IncidentReport WHERE ReportID=@ReportID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@ReportID", SqlDbType.Int).Value = id;
                return cmd.ExecuteNonQuery();
            }
        }

        //Yen added this function.
        /*
        private string GetCarNameFromCarID(int Car_ID)
        {
            string CarName = "";
            string sqlQuery = "SELECT Name FROM Car WHERE CarID=@CarID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@CarID", SqlDbType.Int).Value = Car_ID;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CarName = reader["Name"].ToString();
                    }
                }
            }
            return CarName;
        }
        */
    }
}
