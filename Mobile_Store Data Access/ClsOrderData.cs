using Mobile_Store_Data_Access;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Mobile_Store_DataAccess
{
    public class ClsOrderData
    {
        public static int AddNewOrder(string CustomerName, string CustomerPhone,
            string CustomerAddress, DateTime OrderDate, decimal TotalAmount, byte Status)
        {
            int OrderID = -1;
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);

            string query = @"INSERT INTO Orders (CustomerName, CustomerPhone, CustomerAddress, OrderDate, TotalAmount, Status)
                             VALUES (@CustomerName, @CustomerPhone, @CustomerAddress, @OrderDate, @TotalAmount, @Status);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerName", CustomerName);
            command.Parameters.AddWithValue("@CustomerPhone", (object)CustomerPhone ?? DBNull.Value);
            command.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
            command.Parameters.AddWithValue("@OrderDate", OrderDate);
            command.Parameters.AddWithValue("@TotalAmount", TotalAmount);
            command.Parameters.AddWithValue("@Status", Status);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    OrderID = insertedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return OrderID;
        }

        public static bool UpdateOrder(int OrderID, string CustomerName, string CustomerPhone,
            string CustomerAddress, DateTime OrderDate, decimal TotalAmount, byte Status)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);

            string query = @"UPDATE Orders 
                             SET CustomerName = @CustomerName, 
                                 CustomerPhone = @CustomerPhone, 
                                 CustomerAddress = @CustomerAddress, 
                                 OrderDate = @OrderDate, 
                                 TotalAmount = @TotalAmount, 
                                 Status = @Status
                             WHERE OrderID = @OrderID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@OrderID", OrderID);
            command.Parameters.AddWithValue("@CustomerName", CustomerName);
            command.Parameters.AddWithValue("@CustomerPhone", (object)CustomerPhone ?? DBNull.Value);
            command.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
            command.Parameters.AddWithValue("@OrderDate", OrderDate);
            command.Parameters.AddWithValue("@TotalAmount", TotalAmount);
            command.Parameters.AddWithValue("@Status", Status);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool GetOrderInfoByID(int OrderID, ref string CustomerName,
       ref string CustomerPhone, ref string CustomerAddress,
       ref DateTime OrderDate, ref decimal TotalAmount, ref byte Status)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = "SELECT * FROM Orders WHERE OrderID = @OrderID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@OrderID", OrderID);

            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;
                    CustomerName = Reader["CustomerName"].ToString();

                   
                    CustomerPhone = Reader["CustomerPhone"] != DBNull.Value ? Reader["CustomerPhone"].ToString() : "";

                    CustomerAddress = Reader["CustomerAddress"].ToString();
                    OrderDate = (DateTime)Reader["OrderDate"];
                    TotalAmount = Convert.ToDecimal(Reader["TotalAmount"]);
                    Status = Convert.ToByte(Reader["Status"]);
                }
                Reader.Close();
            }
            catch (Exception ex) { Console.WriteLine("Error: " + ex.Message); }
            finally { connection.Close(); }

            return isFound;
        }

        public static DataTable GetAllOrders()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query =
@"SELECT OrderID, CustomerName, CustomerAddress, OrderDate, TotalAmount
  FROM Orders
  ORDER BY OrderDate DESC";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
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

        public static DataTable GetCustomerOrders()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);

            string query =
            @"SELECT OrderID, CustomerName, CustomerAddress, OrderDate, TotalAmount
      FROM Orders
      WHERE Status = 0
      ORDER BY OrderDate DESC";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            try
            {
                connection.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex) { Console.WriteLine("Error: " + ex.Message); }
            finally { connection.Close(); }

            return dt;
        }
        public static bool DeleteOrder(int OrderID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = @"DELETE FROM OrderItems WHERE OrderID = @OrderID
                             DELETE FROM Orders WHERE OrderID = @OrderID";
                             

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@OrderID", OrderID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }
    }
}