using RideXpress.BLL;
using RideXpress.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RideXpress_StarterKit
{
    public partial class AddReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateOfIncidentValidator.MinimumValue = (DateTime.Now.Date.AddYears(-50)).ToShortDateString();
            DateOfIncidentValidator.MaximumValue = (DateTime.Now.Date).ToShortDateString();
        }

        protected void ReportAddButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["RideXpressConnectionString"].ToString();
                ReportBLL bll = new ReportBLL(connectionString);
                ReportViewModel report = new ReportViewModel();
                report.CarID = Convert.ToInt32(CarID.Text);
                report.DateOfIncident = DateOfIncident.Text;
                report.ReportName = ReportName.Text;
                report.ReportDescription = ReportDescription.Text;
                bll.AddIncidentReport(report);
                Response.Redirect("~/Reports.aspx");
            }
        }
    }
}