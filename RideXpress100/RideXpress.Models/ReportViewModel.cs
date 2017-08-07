using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideXpress.Models
{
    public class ReportViewModel
    {
        public int ReportID { get; set; }
        public int CarID { get; set; }
        public string Name { get; set; }    // The name of the car from CarID
        public string DateOfIncident { get; set; }
        public string ReportName { get; set; }
        public string ReportDescription { get; set; }
        public string DateOfReport { get; set; }
    }
}
