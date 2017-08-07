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
using System.Globalization;

namespace RideXpress_StarterKit
{
    public partial class EditReport : System.Web.UI.Page
    {

        string connectionString = ConfigurationManager.ConnectionStrings["RideXpressConnectionString"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            DateOfIncidentValidator.MinimumValue = (DateTime.Now.Date.AddYears(-30)).ToShortDateString();
            DateOfIncidentValidator.MaximumValue = (DateTime.Now.Date).ToShortDateString();

            if (!IsPostBack)
            {
                BindData();

                ReportBLL bll = new ReportBLL(connectionString);
                ReportViewModel report = bll.GetIncidentReportById(Convert.ToInt32(Request.QueryString["ReportID"]));
                Dictionary<string, int> CarOwner_CarID = GetCarNameFromCarID();

                for (int i = 0; i < CarOwner_CarID.Count; i++)
                {
                    if (CarOwner_CarID.Values.ToList()[i] == report.CarID)
                    {
                        report.Name = CarOwner_CarID.Keys.ToList()[i];
                        break;
                    }
                }

                CarIDList.Text = report.Name;

                //DateOfIncident.Text = DateTime.ParseExact("2009-05-08 14:40:52.531", "yyyy-MM-dd HH:mm:ss.fff", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                //DateOfIncident.Text = DateTime.ParseExact("08-05-2009 02:25:50 AM", "dd-MM-yyyy hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");

                DateOfIncident.Text = DateTime.ParseExact(MakeCompleteDate(report.DateOfIncident), "MM-dd-yyyy hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
                ReportName.Text = report.ReportName;
                ReportDescription.Text = report.ReportDescription;

            }
        }

        protected void ReportEditButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                
                ReportBLL bll = new ReportBLL(connectionString);
                ReportViewModel report = new ReportViewModel();
                Dictionary<string, int> CarOwner_CarID = GetCarNameFromCarID();

                report.ReportID = Convert.ToInt32(Request.QueryString["ReportID"]);

                int i;

                for ( i = 0; i < CarOwner_CarID.Count; i++)
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

                bll.EditIncidentReport(report);
                Response.Redirect("~/Reports.aspx");
            }
        }

        private string MakeCompleteDate(string complete_date_time)
        {
            string[] date_element = complete_date_time.Split('/');
            complete_date_time = "";

            for (int i = 0; i < date_element.Length - 1; i++)
            {
                if (date_element[i].Length == 1)
                {
                    date_element[i] = "0" + date_element[i];
                }
            }

            complete_date_time = date_element[0] + "-" + date_element[1] + "-" + date_element[2];
            return complete_date_time;
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
