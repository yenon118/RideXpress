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
    public partial class EditCar : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["RideXpressConnectionString"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarBLL bll = new CarBLL(connectionString);
                CarViewModel car = bll.GetCarById(Convert.ToInt32(Request.QueryString["CarID"]));
                Name.Text = car.Name;
                Make.Text = car.Make;
                Model.Text = car.Model;
                Trim.Text = car.Trim;
                Year.Text = car.Year.ToString();
                Description.Text = car.Description;
                CityMPG.Text = car.CityMPG.ToString();
                HighwayMPG.Text = car.HighwayMPG.ToString();
                IsAutomatic.SelectedValue = car.IsAutomatic.ToString();
                HourlyRate.Text = car.HourlyRate.ToString();
                YearValidator.MaximumValue = (DateTime.Now.Year + 1).ToString();
            }
        }

        protected void CarEditButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                CarBLL bll = new CarBLL(connectionString);
                CarViewModel car = new CarViewModel();
                car.CarID = Convert.ToInt32(Request.QueryString["CarID"]);
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
                bll.EditCar(car);
                Response.Redirect("~/Cars.aspx");
            }
        }
    }
}