using System;
using System.Data;
using System.Data.SqlClient;

namespace C__Final_Project_MiniMart.DAO 
{
    public class DbHelper
    {
        private static string servername = "TRUNG-LAPTOP\\ELIO";
        private static string dbName = "mini-mart-test";
        private static string username = "";
        private static string password = "";
        private static string connectionString = $"Data Source={servername};Initial Catalog={dbName};Integrated Security=True";
        //private static string connectionString = $"Data Source={servername};Initial Catalog={dbName};User ID={username};Password={password}";

        public static DataTable ExecuteQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dataTable = new DataTable();
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi thực hiện truy vấn SQL: " + ex.Message);
                }
                return dataTable;
            }
        }

        public static int ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi thực hiện câu lệnh SQL: " + ex.Message);
                    return -1;
                }
            }
        }
    }
}


