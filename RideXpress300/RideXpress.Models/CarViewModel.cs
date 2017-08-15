using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideXpress.Models
{
    //This is a POCO, or Plain Old CLR Object that represents
    //a Car, a POCO should only have properties that are represented
    //the same as the database.
    public class CarViewModel
    {
        public int CarID { get; set; }
        public string Name { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Trim { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public int CityMPG { get; set; }
        public int HighwayMPG { get; set; }
        public bool IsAutomatic { get; set; }
        public double HourlyRate { get; set; }
        public string AutomaticDisplay
        {
            get
            {
                if (this.IsAutomatic == true)
                    return "Automatic";
                else
                    return "Manual";
            }
        }
        public double DailyRate
        {
            get
            {
                return this.HourlyRate * 10.0;
            }
        }
    }
}
