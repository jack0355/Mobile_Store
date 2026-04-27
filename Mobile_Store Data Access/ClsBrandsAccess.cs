using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Store_Data_Access
{
    public class ClsBrandsAccess
    {
        public static bool GetBrandsByID(int BrandID, ref string BrandName, ref string LogoURL)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = @"SELECT * FROM brands WHERE brand_id = @BrandID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@BrandID", BrandID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    isFound = true;
                    BrandName = (string)Reader["name"];
                    LogoURL = Reader["logo_url"] != DBNull.Value ? (string)Reader["logo_url"] : "";
                }
                else
                {
                    isFound = false;
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static bool GetBrandByName(string BrandName, ref int BrandID, ref string LogoURL)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = @"SELECT * FROM brands WHERE name = @name";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", BrandName);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    isFound = true;
                    BrandID = (int)Reader["brand_id"];
                    LogoURL = Reader["logo_url"] != DBNull.Value ? (string)Reader["logo_url"] : "";
                }
                else
                {
                    isFound = false;
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static DataTable GetAllBrands()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = @"SELECT * FROM brands ORDER BY name ASC";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                dt.Load(Reader);
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }
}