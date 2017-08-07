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
    /// <summary>
    /// This is the Data Access Layer (DAL) class for the Car table
    /// Uses ADO.NET classes in order to query from the SQL Server 
    /// database.
    /// </summary>
    public class CarDAL
    {
        private string _connectionString;
        public CarDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<CarViewModel> GetCarInventory()
        {
            string sqlQuery = "SELECT * FROM Car";
            List<CarViewModel> cars = new List<CarViewModel>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CarViewModel temp = new CarViewModel()
                        {
                            CarID = Convert.ToInt32(reader["CarID"]),
                            Name = reader["Name"].ToString(),
                            Make = reader["Make"].ToString(),
                            Model = reader["Model"].ToString(),
                            Trim = reader["Trim"].ToString(),
                            Year = Convert.ToInt32(reader["Year"]),
                            Description = reader["Description"].ToString(),
                            CityMPG = Convert.ToInt32(reader["CityMPG"]),
                            HighwayMPG = Convert.ToInt32(reader["HighwayMPG"]),
                            IsAutomatic = Convert.ToBoolean(reader["IsAutomatic"]),
                            HourlyRate = Convert.ToDouble(reader["HourlyRate"])
                        };
                        cars.Add(temp);
                    }
                }
            }
            return cars;
        }

        public CarViewModel GetCarById(int id)
        {
            CarViewModel car = new CarViewModel();
            string sqlQuery = "SELECT * FROM Car WHERE CarID=@CarID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@CarID", SqlDbType.Int).Value = id;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        car.CarID = Convert.ToInt32(reader["CarID"]);
                        car.Name = reader["Name"].ToString();
                        car.Make = reader["Make"].ToString();
                        car.Model = reader["Model"].ToString();
                        car.Trim = reader["Trim"].ToString();
                        car.Year = Convert.ToInt32(reader["Year"]);
                        car.Description = reader["Description"].ToString();
                        car.CityMPG = Convert.ToInt32(reader["CityMPG"]);
                        car.HighwayMPG = Convert.ToInt32(reader["HighwayMPG"]);
                        car.IsAutomatic = Convert.ToBoolean(reader["IsAutomatic"]);
                        car.HourlyRate = Convert.ToDouble(reader["HourlyRate"]);
                    }
                }
            }
            return car;
        }
        public int EditCar(CarViewModel edit)
        {
            string sqlQuery = "UPDATE Car SET Name=@Name, Make=@Make, Model=@Model, Trim=@Trim, Year=@Year, " +
                "Description=@Description, CityMPG=@CityMPG, HighwayMPG=@HighwayMPG, IsAutomatic=@IsAutomatic, " +
                "HourlyRate=@HourlyRate WHERE CarID=@CarID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@CarID", SqlDbType.Int).Value = edit.CarID;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = edit.Name;
                cmd.Parameters.Add("@Make", SqlDbType.VarChar).Value = edit.Make;
                cmd.Parameters.Add("@Model", SqlDbType.VarChar).Value = edit.Model;
                cmd.Parameters.Add("@Trim", SqlDbType.VarChar).Value = edit.Trim;
                cmd.Parameters.Add("@Year", SqlDbType.Int).Value = edit.Year;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = edit.Description;
                cmd.Parameters.Add("@CityMPG", SqlDbType.Int).Value = edit.CityMPG;
                cmd.Parameters.Add("@HighwayMPG", SqlDbType.Int).Value = edit.HighwayMPG;
                cmd.Parameters.Add("@IsAutomatic", SqlDbType.Bit).Value = edit.IsAutomatic;
                cmd.Parameters.Add("@HourlyRate", SqlDbType.Decimal).Value = edit.HourlyRate;
                return cmd.ExecuteNonQuery();
            }
        }
        public int AddCar(CarViewModel add)
        {
            string sqlQuery = "INSERT INTO Car (Name, Make, Model, Trim, Year, Description, CityMPG, HighwayMPG, " +
                "IsAutomatic, HourlyRate) VALUES (@Name, @Make, @Model, @Trim, @Year, @Description, @CityMPG, " +
                "@HighwayMPG, @IsAutomatic, @HourlyRate)";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@CarID", SqlDbType.Int).Value = add.CarID;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = add.Name;
                cmd.Parameters.Add("@Make", SqlDbType.VarChar).Value = add.Make;
                cmd.Parameters.Add("@Model", SqlDbType.VarChar).Value = add.Model;
                cmd.Parameters.Add("@Trim", SqlDbType.VarChar).Value = add.Trim;
                cmd.Parameters.Add("@Year", SqlDbType.Int).Value = add.Year;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = add.Description;
                cmd.Parameters.Add("@CityMPG", SqlDbType.VarChar).Value = add.CityMPG;
                cmd.Parameters.Add("@HighwayMPG", SqlDbType.VarChar).Value = add.HighwayMPG;
                cmd.Parameters.Add("@IsAutomatic", SqlDbType.VarChar).Value = add.IsAutomatic;
                cmd.Parameters.Add("@HourlyRate", SqlDbType.VarChar).Value = add.HourlyRate;
                return cmd.ExecuteNonQuery();
            }
        }
        public int DeleteCar(int id)
        {
            string sqlQuery = "DELETE FROM Car WHERE CarID=@CarID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@CarID", SqlDbType.Int).Value = id;
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
