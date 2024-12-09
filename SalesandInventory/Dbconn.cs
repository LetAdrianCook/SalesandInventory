using MySql.Data.MySqlClient;
using System;

namespace SalesandInventory
{
    internal class Dbconn
    {
        private string connectionString;

        // Constructor to initialize the connection string
        public Dbconn()
        {
            // Set up the connection string with the specified parameters
            connectionString = "server=127.0.1.1;user=root;database=salesinv;password=;";
        }
    

        // Method to get a new MySqlConnection
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Optional: Method to test the connection
        public bool TestConnection()
        {
            using (var connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    return true; // Connection successful
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return false; // Connection failed
                }
            }
        }
    }
}