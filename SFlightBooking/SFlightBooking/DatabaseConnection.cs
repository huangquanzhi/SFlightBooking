using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SFlightBooking
{
    class DatabaseConnection
    {

        private string connectionString;
        private string address;
        private string catalog;
        private string security;
        private string userName;
        private string password;

        public DatabaseConnection()
        {

            address = "107.180.3.101";
            catalog = "SheridanProject";
            security = "SSPI";
            userName = "sheridan";
            password = "password";

            
            connectionString = "server=" + address +
                ";datbase=" + catalog +
                ";uid=" + userName +
                ";pwd=" + password + ";";
        }

        public DatabaseConnection(string connectionString)
        {
            this.connectionString = connectionString;


        }

        public MySqlConnection CreateConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public MySqlCommand CreateCommand(MySqlConnection conn)
        {
            MySqlCommand cmd = null;

            try
            {
                cmd = conn.CreateCommand();
                return cmd;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public void CloseConnection(MySqlConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
