using RideXpress.DAL;
using RideXpress.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideXpress.BLL
{
    public class EmployeeBLL
    {
        private EmployeeDAL data;

        public EmployeeBLL(string connectionString)
        {
            data = new EmployeeDAL(connectionString);
        }

        public List<EmployeeViewModel> GetEmployeeInventory()
        {
            List<EmployeeViewModel> employees = new List<EmployeeViewModel>();
            foreach (EmployeeViewModel model in data.GetEmployeeInventory())
            {
                employees.Add(model);
            }
            return employees;
        }

        public EmployeeViewModel GetEmployeeById(int id)
        {
            return data.GetEmployeeById(id);
        }

        public int EditEmployee(EmployeeViewModel edit)
        {
            return data.EditEmployee(edit);
        }

        public int AddEmployee(EmployeeViewModel add)
        {
            return data.AddEmployee(add);
        }

        public int DeleteEmployee(int id)
        {
            return data.DeleteEmployee(id);
        }

    }
}
