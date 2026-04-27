using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static Mobile_Store_Data_Access.ClsProductsData;
namespace Mobile_Store_Data_Access
{
    public class ClsProductSpecsData
    {
        public static bool GetProduct_SpecsByID(int ProductID , ref int spec_id ,ref string Storage , ref string Ram , ref string Screen_Size 
                                                    , ref string Battery , ref string Color , ref string os)

        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = @"Select * from product_specs where product_id = @product_id";
            SqlCommand cmd = new SqlCommand(query , connection);
            cmd.Parameters.AddWithValue("@product_id", ProductID);
            try
            {
                connection.Open();
                SqlDataReader Reader = cmd.ExecuteReader();
                if (Reader.Read())
                {
                    spec_id = (int)Reader["spec_id"];
                    Storage = (string)Reader["storage"];
                    Ram = (string)Reader["ram"];
                    Screen_Size = (string)Reader["screen_size"];
                    Battery = (string)Reader["battery"];
                    Color = (string)Reader["color"];
                    os = (string)Reader["os"];

                    isFound = true;
                }
                else
                {
                    isFound = false;
                }

                    Reader.Close();

            }
            catch (Exception ex)
            {
                isFound = false;
                Console.WriteLine("error" + ex.Message);

            }
            finally
            {
                connection.Close();

            }
            return isFound;
        }

        public static int AddProduct_Specs(int ProductID, string Storage, string Ram,
                                    string Screen_Size, string Battery,
                                    string Color, string OS)
        {
            int Spec_ID = -1;
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = @"insert into product_specs ( product_id , storage ,ram , screen_size , battery , color , os )
                                               VALUES(@product_id , @storage ,@ram , @screen_size , @battery , @color , @os)
                                               SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@product_id" , ProductID );
            cmd.Parameters.AddWithValue("@storage", Storage);
            cmd.Parameters.AddWithValue("@ram", Ram);
            cmd.Parameters.AddWithValue("@screen_size", Screen_Size);
            cmd.Parameters.AddWithValue("@battery", Battery);
            cmd.Parameters.AddWithValue("@color", Color);
            cmd.Parameters.AddWithValue("@os", OS);
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    Spec_ID = insertedID;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);

            }
            finally
            {
                connection.Close();
            }

            return Spec_ID;

        }


        public static bool UpdateProduct_Spec(int Spec_id ,int ProductID, string Storage, string Ram,
                                    string Screen_Size, string Battery,
                                    string Color, string OS)

        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = @"UPDATE product_specs
                            SET product_id = @product_id ,
                                storage = @storage , ram = @ram , screen_size = @screen_size , battery = @battery , color = @color  , os = @os 
                                where spec_id = @spec_id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@spec_id", Spec_id);
            cmd.Parameters.AddWithValue("@product_id", ProductID);
            cmd.Parameters.AddWithValue("@storage", Storage);
            cmd.Parameters.AddWithValue("@ram", Ram);
            cmd.Parameters.AddWithValue("@screen_size", Screen_Size);
            cmd.Parameters.AddWithValue("@battery", Battery);
            cmd.Parameters.AddWithValue("@color", Color);
            cmd.Parameters.AddWithValue("@os", OS);
            try
            {
                connection.Open();
                rowsAffected = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);

        }

        public static bool DeleteProduct_Specs(int spec_id)

        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = @"DELETE  from product_specs where spec_id = @spec_id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@spec_id", spec_id);
            try
            {
                connection.Open();
                rowsAffected = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                connection.Close();

            }
            return (rowsAffected > 0);
        }

    }
    }
