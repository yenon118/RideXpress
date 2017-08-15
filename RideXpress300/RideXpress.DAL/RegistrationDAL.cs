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
    public class RegistrationDAL
    {
        private string _connectionString;

        public RegistrationDAL(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<RegistrationViewModel> GetRegistrationInventory()
        {
            string sqlQuery = "SELECT * FROM Registration";
            List<RegistrationViewModel> registrations = new List<RegistrationViewModel>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        RegistrationViewModel temp = new RegistrationViewModel()
                        {
                            UserID = Convert.ToInt32(reader["UserID"]),
                            Username = reader["Username"].ToString(),
                            Email = reader["Email"].ToString(),
                            Password = reader["Password"].ToString(),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Address = reader["Address"].ToString(),
                            City = reader["City"].ToString(),
                            State = reader["State"].ToString(),
                            ZipCode = Convert.ToInt32(reader["ZipCode"]),
                            DriversLicense = reader["DriversLicense"].ToString(),
                            BirthDate = reader["BirthDate"].ToString(),
                            LicenseExpirationDate = reader["LicenseExpirationDate"].ToString(),
                            LicenseIssuedState = reader["LicenseIssuedState"].ToString()
                        };
                        registrations.Add(temp);
                    }
                }
            }
            return registrations;
        }

        public RegistrationViewModel GetRegistrationById(int id)
        {
            RegistrationViewModel registration = new RegistrationViewModel();
            string sqlQuery = "SELECT * FROM Registration WHERE UserID=@UserID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = id;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        registration.UserID = Convert.ToInt32(reader["UserID"]);
                        registration.Username = reader["Username"].ToString();
                        registration.Email = reader["Email"].ToString();
                        registration.Password = reader["Password"].ToString();
                        registration.FirstName = reader["FirstName"].ToString();
                        registration.LastName = reader["LastName"].ToString();
                        registration.Address = reader["Address"].ToString();
                        registration.City = reader["City"].ToString();
                        registration.State = reader["State"].ToString();
                        registration.ZipCode = Convert.ToInt32(reader["ZipCode"]);
                        registration.DriversLicense = reader["DriversLicense"].ToString();
                        registration.BirthDate = reader["BirthDate"].ToString();
                        registration.LicenseExpirationDate = reader["LicenseExpirationDate"].ToString();
                        registration.LicenseIssuedState = reader["LicenseIssuedState"].ToString();
                    }
                }
            }
            return registration;
        }

        public int EditRegistration(RegistrationViewModel edit)
        {
            string sqlQuery = "UPDATE Registration SET Username=@Username, Email=@Email, Password=@Password, FirstName=@FirstName, " + 
                              "LastName=@LastName, Address=@Address, City=@City, State=@State, ZipCode=@ZipCode, DriversLicense=@DriversLicense" + 
                              "BirthDate=@BirthDate, LicenseExpirationDate=@LicenseExpirationDate, LicenseIssuedState=@LicenseIssuedState " +
                              "WHERE UserID=@UserID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = edit.UserID;
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = edit.Username;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = edit.Email;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = edit.Password;
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = edit.FirstName;
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = edit.LastName;
                cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = edit.Address;
                cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = edit.City;
                cmd.Parameters.Add("@State", SqlDbType.VarChar).Value = edit.State;
                cmd.Parameters.Add("@ZipCode", SqlDbType.Int).Value = edit.ZipCode;
                cmd.Parameters.Add("@DriversLicense", SqlDbType.VarChar).Value = edit.DriversLicense;
                cmd.Parameters.Add("@BirthDate", SqlDbType.VarChar).Value = edit.BirthDate;
                cmd.Parameters.Add("@LicenseExpirationDate", SqlDbType.VarChar).Value = edit.LicenseExpirationDate;
                cmd.Parameters.Add("@LicenseIssuedState", SqlDbType.VarChar).Value = edit.LicenseIssuedState;

                return cmd.ExecuteNonQuery();
            }
        }

        public int AddRegistration(RegistrationViewModel add)
        {
            string sqlQuery = "INSERT INTO Registration (Username, Email, Password, FirstName, LastName, Address, City, " + 
                              "State, ZipCode, DriversLicense, BirthDate, LicenseExpirationDate, LicenseIssuedState) " +
                              "VALUES (@Username, @Email, @Password, @FirstName, @LastName, @Address, @City, @State, @ZipCode, " +
                              "@DriversLicense, @BirthDate, @LicenseExpirationDate, @LicenseIssuedState)";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = add.Username;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = add.Email;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = add.Password;
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = add.FirstName;
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = add.LastName;
                cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = add.Address;
                cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = add.City;
                cmd.Parameters.Add("@State", SqlDbType.VarChar).Value = add.State;
                cmd.Parameters.Add("@ZipCode", SqlDbType.Int).Value = add.ZipCode;
                cmd.Parameters.Add("@DriversLicense", SqlDbType.VarChar).Value = add.DriversLicense;
                cmd.Parameters.Add("@BirthDate", SqlDbType.VarChar).Value = add.BirthDate;
                cmd.Parameters.Add("@LicenseExpirationDate", SqlDbType.VarChar).Value = add.LicenseExpirationDate;
                cmd.Parameters.Add("@LicenseIssuedState", SqlDbType.VarChar).Value = add.LicenseIssuedState;
                return cmd.ExecuteNonQuery();
            }
        }

        public int DeleteRegistration(int id)
        {
            string sqlQuery = "DELETE FROM Registration WHERE UserID=@UserID";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = id;
                return cmd.ExecuteNonQuery();
            }
        }

        //Add this for testing
        public RegistrationViewModel GetRegistrationByUsername(string Username)
        {
            RegistrationViewModel registration = new RegistrationViewModel();
            string sqlQuery = "SELECT * FROM Registration WHERE Username=@Username";
            using (SqlConnection con = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                con.Open();
                cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        registration.UserID = Convert.ToInt32(reader["UserID"]);
                        registration.Username = reader["Username"].ToString();
                        registration.Email = reader["Email"].ToString();
                        registration.Password = reader["Password"].ToString();
                        registration.FirstName = reader["FirstName"].ToString();
                        registration.LastName = reader["LastName"].ToString();
                        registration.Address = reader["Address"].ToString();
                        registration.City = reader["City"].ToString();
                        registration.State = reader["State"].ToString();
                        registration.ZipCode = Convert.ToInt32(reader["ZipCode"]);
                        registration.DriversLicense = reader["DriversLicense"].ToString();
                        registration.BirthDate = reader["BirthDate"].ToString();
                        registration.LicenseExpirationDate = reader["LicenseExpirationDate"].ToString();
                        registration.LicenseIssuedState = reader["LicenseIssuedState"].ToString();
                    }
                }
            }
            return registration;
        }






    }
}
