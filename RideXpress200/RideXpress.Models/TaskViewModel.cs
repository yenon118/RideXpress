using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideXpress.Models
{
    public class TaskViewModel
    {
        public int TaskID { get; set; }
        public int CarID { get; set; }
        public int EmployeeID { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public string DateAssigned { get; set; }
        public bool TaskStatus { get; set; }
        public string DateComplete { get; set; }

        public string CarName { get; set; }

        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }

        public string EmployeeName
        {
            get { return EmployeeFirstName + " " + EmployeeLastName; }
        }

        public string TaskStatusDisplay
        {
            get
            {
                if (TaskStatus == true)
                    return "Active";
                else
                    return "Completed";
            }
        }






    }
}
