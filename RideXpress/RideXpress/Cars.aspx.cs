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
    public partial class Cars : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["RideXpressConnectionString"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        protected void CarList_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int carID = Convert.ToInt32(CarList.DataKeys[e.RowIndex].Value.ToString());
            CarBLL carBL = new CarBLL(connectionString);
            carBL.DeleteCar(carID);
            BindData();
        }

        private void BindData()
        {
            CarBLL carBL = new CarBLL(connectionString);
            CarList.DataSource = carBL.GetCarInventory();
            CarList.DataBind();
        }
    }
}