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

        private bool DeleteAllTicketByCustomer(MySqlCommand cmd, Customer c)
        {
            // Uid is auto-increment
            try
            {
                cmd.CommandText = "DELETE FROM Ticket WHERE uid = @uid";

                cmd.Parameters.AddWithValue("@uid", c.Uid);

                cmd.ExecuteNonQuery();

                return true;

            }
            catch
            {
                throw;
            }

        }

        public bool RemoveCustomer(MySqlCommand cmd, Customer c)
        {
            try
            {
                if (DeleteAllTicketByCustomer(cmd, c))
                {
                    // clear parameter
                    cmd.Parameters.Clear();

                    cmd.CommandText = "DELETE FROM Customer WHERE uid = @uid";

                    cmd.Parameters.AddWithValue("@uid", c.Uid);

                    if (0 < cmd.ExecuteNonQuery())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                } else
                {
                    throw new Exception("Failed to remove tickets!");
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Remove customer - " + ex.Message.ToString());
            }
        }

    }
}
