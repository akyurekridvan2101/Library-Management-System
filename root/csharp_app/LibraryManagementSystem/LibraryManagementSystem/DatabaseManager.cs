using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace LibraryManagementSystem
{
    public class DatabaseManager
    {
        private string connectionString; // Veritabanı bağlantı dizesi
        private NpgsqlConnection connection; // NpgsqlConnection nesnesi

        public DatabaseManager(string host, string database, string username, string password)
        {
            // PostgreSQL veritabanına bağlanma dizesi oluşturma
            connectionString = $"Host = {host};Username = {username};Password = {password};Database={database};";
            connection = new NpgsqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open(); // Bağlantıyı açma
            }
        }

        public void CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close(); // Bağlantıyı kapatma
            }
        }

        public NpgsqlConnection GetConnection()
        {
            return connection; // Bağlantıyı döndürme
        }
    }

}
