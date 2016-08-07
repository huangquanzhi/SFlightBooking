using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SFlightBooking.Connection
{
    class Insert
    {

        public bool AddCustomer(MySqlCommand cmd, Customer c)
        {
            // Uid is auto-increment
            try
            {
                // create command
                cmd.CommandText = "INSERT INTO Customer VALUES(@uid,@fName, @lName, @address, @phone, @gender, @birthDate, @enName, @enRelation, @enPhone)";
                cmd.Parameters.AddWithValue("@uid", null);
                cmd.Parameters.AddWithValue("@fName", c.FirstName);
                cmd.Parameters.AddWithValue("@lName", c.LastName);
                cmd.Parameters.AddWithValue("@address", c.BirthDate);
                cmd.Parameters.AddWithValue("@phone", c.Gender);
                cmd.Parameters.AddWithValue("@gender", c.Phone);
                cmd.Parameters.AddWithValue("@birthDate", c.BirthDate);
                cmd.Parameters.AddWithValue("@enName", c.EnmergencyName);
                cmd.Parameters.AddWithValue("@enRelation", c.EnmergencyRelationship);
                cmd.Parameters.AddWithValue("@enPhone", c.EnmergencyPhone);

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

        public bool BookFlight(MySqlCommand cmd, Customer c, Flight f)
        {

            try
            {
                // create command
                cmd.CommandText = "INSERT INTO Ticket VALUES(@uid,@flightID)";
                cmd.Parameters.AddWithValue("@uid", c.Uid);
                cmd.Parameters.AddWithValue("@flightID", f.FlightID);

                if (0 < cmd.ExecuteNonQuery())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Can not book or flight already booked!");
            }
        }

    }


}
