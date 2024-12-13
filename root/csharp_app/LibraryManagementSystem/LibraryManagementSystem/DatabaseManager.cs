using System;
using System.Data;
using Microsoft.Data.SqlClient; // SQL Server için kullanacağımız kütüphane

namespace LibraryManagementSystem
{
    public class DatabaseManager
    {
        private string connectionString; // Veritabanı bağlantı dizesi
        private SqlConnection connection; // SqlConnection nesnesi

        public DatabaseManager(string server, string database)
        {
            // SQL Server veritabanına bağlanma dizesi oluşturma
            connectionString = $"Server={server};Database={database};Integrated Security=True;TrustServerCertificate=True;";
            connection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open(); // Bağlantıyı açma
            }
        }

        public void CloseConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close(); // Bağlantıyı kapatma
            }
        }

        public SqlConnection GetConnection()
        {
            return connection; // Bağlantıyı döndürme
        }
    }
}
