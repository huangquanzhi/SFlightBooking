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

        public DatabaseConnection()
        {
            connectionString = "Connection";
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
            return conn.CreateCommand();
        }

        public void CloseConnection(SqlConnection conn)
        {
            conn.Close();
        } 

    }
}
