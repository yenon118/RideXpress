using RideXpress.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            ReportList.DataSource = ReportBL.GetIncidentReportInventory();
            ReportList.DataBind();
        }
    }
}