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
    public partial class Reports : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["RideXpressConnectionString"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        protected void ReportList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ReportID = Convert.ToInt32(ReportList.DataKeys[e.RowIndex].Value.ToString());
            ReportBLL ReportBL = new ReportBLL(connectionString);
            ReportBL.DeleteIncidentReport(ReportID);
            BindData();
        }

        private void BindData()
        {
            ReportBLL ReportBL = new ReportBLL(connectionString);
            List<ReportViewModel> incident_reports = ReportBL.GetIncidentReportInventory();
            foreach (ReportViewModel model in incident_reports)
            {
                model.Name = GetCarNameFromCarID(model.CarID);
            }
            ReportList.DataSource = incident_reports;
            ReportList.DataBind();
        }

        private string GetCarNameFromCarID(int Car_ID)
        {
            string CarName = "";
            string sqlQuery = "SELECT Name FROM Car WHERE CarID=@CarID";
            using (SqlConnection con = new SqlConnection(connectionString))
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
    }
}