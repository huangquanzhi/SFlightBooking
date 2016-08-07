using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            connectionString = "Data Source=" + address +
                ";Initial Catalog=" + catalog +
                ";Integrated Security=" + security +
                ";User Id=" + userName +
                ";Password=" + password + ";";
        }

        public DatabaseConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(connectionString);
        }

        public SqlCommand CreateCommand(SqlConnection conn)
        {
            SqlCommand cmd = null;

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

        public void CloseConnection(SqlConnection conn)
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
