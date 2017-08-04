using RideXpress.DAL;
using RideXpress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideXpress.BLL
{
    /// <summary>
    /// This is the Business Logic Layer (BLL) class for RideXpress.
    /// The Business Logic Layer should only have dependencies on 
    /// the RideXpress.Models project and the RideXpress.DAL project
    /// The BLL is responsible for grabbing any data to/from the DAL
    /// and performing any "business logic" on the data to be presentable
    /// to the web application.
    /// </summary>
    public class CarBLL
    {
        private CarDAL data;
        public CarBLL(string connectionString)
        {
            data = new CarDAL(connectionString);
        }

        public List<CarViewModel> GetCarInventory()
        {
            List<CarViewModel> cars = new List<CarViewModel>();
            foreach (CarViewModel model in data.GetCarInventory())
            {
                cars.Add(model);
            }
            return cars;
        }

        public CarViewModel GetCarById(int id)
        {
            return data.GetCarById(id);
        }

        public int EditCar(CarViewModel edit)
        {
            return data.EditCar(edit);
        }

        public int AddCar(CarViewModel add)
        {
            return data.AddCar(add);
        }

        public int DeleteCar(int id)
        {
            return data.DeleteCar(id);
        }
    }
}
