using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideXpress.Models
{
    public class EmployeeViewModel
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public string BirthDate { get; set; }
        public string JobTitle { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public string Name
        {
            get { return FirstName + " " + LastName; }
        }

        public string GenderDisplay
        {
            get
            {
                if (Gender == true)
                    return "Male";
                else
                    return "Female";
            }
        }

        public bool WorkingStatus
        {
            get
            {
                if (string.IsNullOrEmpty(EndDate))
                    return true;
                else
                    return false;
            }
        }

    }
}
