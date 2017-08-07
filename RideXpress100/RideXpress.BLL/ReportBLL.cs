using RideXpress.DAL;
using RideXpress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideXpress.BLL
{
    public class ReportBLL
    {
        private ReportDAL data;

        public ReportBLL(string connectionString)
        {
            data = new ReportDAL(connectionString);
        }

        public List<ReportViewModel> GetIncidentReportInventory()
        {
            List<ReportViewModel> incident_reports = new List<ReportViewModel>();
            foreach (ReportViewModel model in data.GetIncidentReportInventory())
            {
                incident_reports.Add(model);
            }
            return incident_reports;
        }

        public ReportViewModel GetIncidentReportById(int id)
        {
            return data.GetIncidentReportById(id);
        }

        public int EditIncidentReport(ReportViewModel edit)
        {
            return data.EditIncidentReport(edit);
        }

        public int AddIncidentReport(ReportViewModel add)
        {
            return data.AddIncidentReport(add);
        }

        public int DeleteIncidentReport(int id)
        {
            return data.DeleteIncidentReport(id);
        }
    }
}
