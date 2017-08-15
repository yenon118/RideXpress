using RideXpress.DAL;
using RideXpress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RideXpress.BLL
{
    public class RegistrationBLL
    {
        private RegistrationDAL data;

        public RegistrationBLL(string connectionString)
        {
            data = new RegistrationDAL(connectionString);
        }

        public List<RegistrationViewModel> GetRegistrationInventory()
        {
            List<RegistrationViewModel> registrations = new List<RegistrationViewModel>();
            foreach (RegistrationViewModel model in data.GetRegistrationInventory())
            {
                registrations.Add(model);
            }
            return registrations;
        }

        public RegistrationViewModel GetRegistrationById(int id)
        {
            return data.GetRegistrationById(id);
        }

        public int EditRegistration(RegistrationViewModel edit)
        {
            return data.EditRegistration(edit);
        }

        public int AddRegistration(RegistrationViewModel add)
        {
            return data.AddRegistration(add);
        }

        public int DeleteRegistration(int id)
        {
            return data.DeleteRegistration(id);
        }

        //Add this for testing
        public RegistrationViewModel GetRegistrationByUsername(string Username)
        {
            return data.GetRegistrationByUsername(Username);
        }






    }
}
