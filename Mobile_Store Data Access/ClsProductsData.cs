using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Store_Data_Access
{
    public class ClsProductsData
    {
        public static bool GetThePhoneByName(string ProductName , ref int ProductID , ref int BrandID , ref int CategoryID , ref  decimal Price ,
                                              ref string ImageURL , ref string Description , ref bool IsAvailable)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = @"SELECT * FROM  products where name = @name";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", ProductName);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    isFound = true;
                    ProductID = (int)Reader["product_id"];
                    BrandID = (int)Reader["brand_id"];
                    CategoryID = (int)Reader["category_id"];
                    Price = (decimal)Reader["price"];

                    ImageURL = Reader["image_url"] != DBNull.Value ? (string)Reader["image_url"] : "";

                    Description = Reader["description"] != DBNull.Value ? (string)Reader["description"] : "";

                    IsAvailable = (bool)Reader["is_available"];

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
                Console.WriteLine("Error" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isFound;

        }

        public static bool GetThePhoneByProductID(int ProductID, ref string ProductName, ref int BrandID, ref int CategoryID, ref decimal Price,
                                                  ref string ImageURL, ref string Description, ref bool IsAvailable)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = @"SELECT * FROM  products where product_id = @product_id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@product_id" , ProductID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    isFound = true;
                    ProductName = (string)Reader["name"];
                    BrandID = (int)Reader["brand_id"];
                    CategoryID = (int)Reader["category_id"];
                    Price = (decimal)Reader["price"];

                    ImageURL = Reader["image_url"] != DBNull.Value ? (string)Reader["image_url"] : "";

                    Description = Reader["description"] != DBNull.Value ? (string)Reader["description"] : "";

                    IsAvailable = (bool)Reader["is_available"];

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
                Console.WriteLine("Error" +ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isFound;

        }

        public static DataTable GetAllThePhoneProducts()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = @"SELECT 
                            p.product_id, 
       b.name AS Brand, 
       c.name AS Category,
       p.name, 
       p.price, 
       p.image_url,
       p.is_available
From products p 
inner join brands b ON p.brand_id  =  b.brand_id
inner join categories c ON p.category_id  = c.category_id
order by  p.name ASC";


            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
              
                
                    dt.Load(reader);

                
                reader.Close();

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

        public static int AddNewPhone( int BrandID ,int CategoryID , string ProductName, 
                                   decimal Price , string ImageURL , string Description , 
                                   bool IsAvailable )
        {
            int Product_id = -1;
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = @"INSERT INTO products ([brand_id]
           ,[category_id]
           ,[name]
           ,[price]
           ,[image_url]
           ,[description]
           ,[is_available]) VALUES (@BrandID, @CategoryID, @Name, @Price, @ImageURL, @Description, @IsAvailable)
           SELECT SCOPE_IDENTITY()";
           
            SqlCommand command =new SqlCommand(query , connection);
            // You forgot this one!
            command.Parameters.AddWithValue("@BrandID", BrandID);
            command.Parameters.AddWithValue("@CategoryID", CategoryID);
            command.Parameters.AddWithValue("@Name", ProductName);
            command.Parameters.AddWithValue("@Price", Price);
            command.Parameters.AddWithValue("@ImageURL",
                   !string.IsNullOrEmpty(ImageURL) ? (object)ImageURL : DBNull.Value);
            command.Parameters.AddWithValue("@Description",
                   !string.IsNullOrEmpty(Description) ? (object)Description : DBNull.Value);
            command.Parameters.AddWithValue("@IsAvailable", IsAvailable);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedProduct_id))
                {
                    Product_id = insertedProduct_id;
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
            return Product_id;

        }

        public static bool UpdatePhone(int ProductID ,int BrandID, int CategoryID, string ProductName,
                                   decimal Price, string ImageURL, string Description,
                                   bool IsAvailable)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = @"UPDATE products 
                              set 
            brand_id = @brand_id
           ,category_id = @category_id
           ,name  = @name
           ,price =  @price 
           ,image_url = @image_url
           ,description = @description
           ,is_available = @is_available  
           where product_id = @product_id
            ";
            // You forgot this one!
            SqlCommand command= new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@product_id", ProductID);
            command.Parameters.AddWithValue("@Price", Price);
            command.Parameters.AddWithValue("@brand_id", BrandID);
            command.Parameters.AddWithValue("@category_id", CategoryID);
            command.Parameters.AddWithValue("@name", ProductName);

            if (!string.IsNullOrEmpty(ImageURL))
                command.Parameters.AddWithValue("@image_url", ImageURL);
            else
                command.Parameters.AddWithValue("@image_url", DBNull.Value);

            if (!string.IsNullOrEmpty(Description))
                command.Parameters.AddWithValue("@description", Description);
            else
                command.Parameters.AddWithValue("@description", DBNull.Value);

            command.Parameters.AddWithValue("@is_available", IsAvailable);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
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


        public static bool DeletePhone(int ProductID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = @"DELETE FROM product_specs WHERE product_id = @product_id
                     DELETE FROM products WHERE product_id = @product_id";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@product_id", ProductID);
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

