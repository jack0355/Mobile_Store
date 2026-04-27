using Mobile_Store_Data_Access;
using System;
using System.Data.SqlClient;

public class ClsUsersData
{
    public static bool CheckLogin(string Username, string Password)
    {
        bool isFound = false;
        SqlConnection connection = new SqlConnection(ClsConnectionString.ConnectionString);
        string query = @"SELECT * FROM users 
                        WHERE username = @username 
                        AND password = @password";
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@username", Username);
        command.Parameters.AddWithValue("@password", Password);
        try
        {
            connection.Open();
            SqlDataReader Reader = command.ExecuteReader();
            if (Reader.Read())
                isFound = true;
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
}