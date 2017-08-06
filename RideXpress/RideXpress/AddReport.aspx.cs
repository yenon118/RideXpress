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
    public partial class AddReport : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["RideXpressConnectionString"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            DateOfIncidentValidator.MinimumValue = (DateTime.Now.Date.AddYears(-30)).ToShortDateString();
            DateOfIncidentValidator.MaximumValue = (DateTime.Now.Date).ToShortDateString();

            if (!IsPostBack)
            {
                BindData();
            }
        }

        protected void ReportAddButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                ReportBLL bll = new ReportBLL(connectionString);
                ReportViewModel report = new ReportViewModel();
                Dictionary<string, int> CarOwner_CarID = GetCarNameFromCarID();

                int i;

                for(i=0; i<CarOwner_CarID.Count; i++)
                {
                    if (CarOwner_CarID.Keys.ToList()[i].Equals(CarIDList.SelectedItem.Text))
                    {
                        break;
                    }
                }

                report.CarID = CarOwner_CarID.Values.ToList()[i];
                report.DateOfIncident = DateOfIncident.Text;
                report.ReportName = ReportName.Text;
                report.ReportDescription = ReportDescription.Text;
                report.DateOfReport = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                bll.AddIncidentReport(report);
                Response.Redirect("~/Reports.aspx");
            }
        }

        private void BindData()
        {
            CarIDList.DataSource = GetCarNameFromCarID().Keys;
            CarIDList.DataBind();
        }

        private Dictionary<string, int> GetCarNameFromCarID()
        {
            Dictionary<string, int> CarOwner_CarID = new Dictionary<string, int>();
            string sqlQuery = "SELECT CarID, Name FROM Car";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CarOwner_CarID.Add(reader["Name"].ToString(), Convert.ToInt32(reader["CarID"]));
                    }
                }
            }
            return CarOwner_CarID;
        }
    }
}