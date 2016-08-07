using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFlightBooking.Connection
{
    public class Database
    {

        private string address;
        private string userName;
        private string password;
        private string database;
        private MySqlConnectionStringBuilder connectionString;

        public Database()
        {
            address = "localhost";
            database = "SheridanProject";
            userName = "root";
            password = "password";

            connectionString = new MySqlConnectionStringBuilder();
            connectionString.Server = address;
            connectionString.UserID = userName;
            connectionString.Password = password;
            connectionString.Database = database;

        }

        public MySqlConnection CreateConnection() 
        {

            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(connectionString.ToString());
                return conn;
            } catch (Exception e)
            {
                throw e;
            }
        }

        public MySqlCommand CreateCommand(MySqlConnection conn)
        {
            try
            {
                return conn.CreateCommand();
            } catch
            {
                throw;
            }
        }

    }
}
