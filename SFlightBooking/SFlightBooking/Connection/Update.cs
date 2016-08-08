using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFlightBooking.Connection
{
    class Update
    {

        public bool EditCustomer(MySqlCommand cmd, Customer c)
        {
            // Uid is auto-increment
            try
            {
                // create command
                cmd.CommandText = "UPDATE Customer SET FirstName=@fName, LastName=@lName, Address=@address, Phone=@phone, Gender=@gender, BirthDate=@birthDate, EnName=@enName, EnRelationship=@enRelation, EnPhone=@enPhone "
                    + "WHERE uid=@uid";
                cmd.Parameters.AddWithValue("@uid", c.Uid);
                cmd.Parameters.AddWithValue("@fName", c.FirstName);
                cmd.Parameters.AddWithValue("@lName", c.LastName);
                cmd.Parameters.AddWithValue("@address", c.Address);
                cmd.Parameters.AddWithValue("@phone", c.Phone);
                cmd.Parameters.AddWithValue("@gender", c.Gender);
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

    }
}
