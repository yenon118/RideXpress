using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideXpress.Models
{
    class ReportViewModel
    {
        public int ReportID { get; set; }
        public int CarID { get; set; }
        public string DateOfIncident { get; set; }
        public string ReportName { get; set; }
        public string ReportDescription { get; set; }
        public string DateOfReport { get; set; }
    }
}
