using MySql.Data.MySqlClient;
using System.Data;

namespace Diplom
{
    public class AppConnect
    {
        private const string Password = "admin";
        private const string DbName = "DbSecurity";
        private const int Port = 3306;
        private const string Server = "127.0.0.1";
        private const string UserName = "root";
        private string connectionString = $"Server={Server};;database={DbName};Port={Port};User id={UserName};Password={Password}";

        private readonly MySqlConnection connection;

        public AppConnect()
        {
            connection = new MySqlConnection(connectionString);
        }
        public MySqlConnection Connection => connection;
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                return;
            }
            connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                return;
            }
            connection.Close();
        }
    }
}
