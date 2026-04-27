using Mobile_Store_Data_Access;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Mobile_Store_DataAccess
{
    public class ClsOrderItemData
    {
        public static DataTable GetItemsByOrderID(int OrderID)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);

       
            string query = "SELECT ProductName, Quantity, UnitPrice, TotalPrice FROM OrderItems WHERE OrderID = @OrderID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@OrderID", OrderID);

            try
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error"+ex.Message); 
            }
            finally 
            {
                connection.Close(); 
            }

            return dt;
        }

        public static bool AddNewOrderItem(int OrderID, int ProductID, string ProductName, int Quantity, decimal UnitPrice, decimal TotalPrice)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
            string query = @"INSERT INTO OrderItems (OrderID, ProductID, ProductName, Quantity, UnitPrice, TotalPrice) 
                             VALUES (@OrderID, @ProductID, @ProductName, @Quantity, @UnitPrice, @TotalPrice)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@OrderID", OrderID);
            command.Parameters.AddWithValue("@ProductID", ProductID);
            command.Parameters.AddWithValue("@ProductName", ProductName);
            command.Parameters.AddWithValue("@Quantity", Quantity);
            command.Parameters.AddWithValue("@UnitPrice", UnitPrice);
            command.Parameters.AddWithValue("@TotalPrice", TotalPrice);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error"+ex.Message);
                return false;
            }

            finally 
            { 
                connection.Close();
            }

            return rowsAffected > 0;
        }
    }
}