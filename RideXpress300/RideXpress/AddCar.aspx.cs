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
    public partial class AddCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            YearValidator.MaximumValue = (DateTime.Now.Year + 1).ToString();
        }

        protected void CarAddButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["RideXpressConnectionString"].ToString();
                CarBLL bll = new CarBLL(connectionString);
                CarViewModel car = new CarViewModel();
                car.Name = Name.Text;
                car.Make = Make.Text;
                car.Model = Model.Text;
                car.Trim = Trim.Text;
                car.Year = Convert.ToInt32(Year.Text);
                car.Description = Description.Text;
                car.CityMPG = Convert.ToInt32(CityMPG.Text);
                car.HighwayMPG = Convert.ToInt32(HighwayMPG.Text);
                car.IsAutomatic = Convert.ToBoolean(IsAutomatic.SelectedValue);
                car.HourlyRate = Convert.ToDouble(HourlyRate.Text);
                bll.AddCar(car);
                Response.Redirect("~/Cars.aspx");
            }
        }
    }
}