using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFlightBooking.Connection
{
    class Delete
    {

        public bool DeleteTicketByCustomer(MySqlCommand cmd, Customer c, Flight f)
        {
            // Uid is auto-increment
            try
            {
                // create command
                cmd.CommandText = "DELETE FROM Ticket WHERE uid = @uid AND flightID = @fid";

                cmd.Parameters.AddWithValue("@uid", c.Uid);
                cmd.Parameters.AddWithValue("@fid", f.FlightID);

                if (0 < cmd.ExecuteNonQuery())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                throw;
            }

        }

    }
}
