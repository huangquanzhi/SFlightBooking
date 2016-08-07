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
            /*
            fbds = new FlightBookingDataSet();

            FlightBookingDataSetTableAdapters.CustomerTableAdapter cta = new FlightBookingDataSetTableAdapters.CustomerTableAdapter();
            cta.Fill(fbds.Customer);

            DataRow row = fbds.Tables["Customer"].NewRow();
            row["fName"] = c.FirstName;
            row["lName"] = c.LastName;
            row["address"] = c.Address;
            row["birthday"] = c.BirthDate;
            row["gender"] = c.Gender;
            row["phone"] = c.Phone;
            row["eName"] = c.EnmergencyName;
            row["eRelation"] = c.EnmergencyRelationship;
            row["ePhone"] = c.EnmergencyPhone;

            fbds.Tables["Customer"].Rows.Add(row);
            cta.Update(fbds.Customer);
            */



        }

    }


}
