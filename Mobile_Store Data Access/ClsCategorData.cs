using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Store_Data_Access
{
    public class ClsCategorData
    {

        public static DataTable GetAllCategories()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = @"Select * from categories order by name desc";
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
                Console.WriteLine("error" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool GetCategoryBYName(string categoryName , ref int CategoryID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = @"Select * from categories where name = @name";
            SqlCommand command =new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", categoryName);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    CategoryID = (int)Reader["category_id"];

                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetCategoryByID(int CategoryID , ref string Categoryname)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = @"Select * from categories where category_id = @category_id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@category_id", CategoryID) ;
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    Categoryname = (string)Reader["name"];
                    isFound = true;
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

    }
}
