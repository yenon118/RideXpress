using RideXpress.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideXpress.DAL
{
    class ReportDAL
    {
        private string _connectionString;
        public ReportDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

    }
}
