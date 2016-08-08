/// <summary>Class for establishing connection to the database</summary>

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
        /// <summary>
        /// Stores the address for the database
        /// </summary>
        private string address;

        /// <summary>
        /// Stores the username credential for login
        /// </summary>
        private string userName;

        /// <summary>
        /// Stores the password credential for login
        /// </summary>
        private string password;

        /// <summary>
        /// The name of the database to access
        /// </summary>
        private string database;

        /// <summary>
        /// Used for building the connection string
        /// </summary>
        private MySqlConnectionStringBuilder connectionString;

        /// <summary>
        /// Class constructor
        /// </summary>
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

        /// <summary>
        /// method for establishing a connection
        /// </summary>
        /// <returns></returns>
        public MySqlConnection CreateConnection()
        {

            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(connectionString.ToString());
                return conn;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Method for creating a MySql  command
        /// </summary>
        /// <param name="conn"></param>
        /// <returns></returns>
        public MySqlCommand CreateCommand(MySqlConnection conn)
        {
            try
            {
                return conn.CreateCommand();
            }
            catch
            {
                throw;
            }
        }

    }
}
