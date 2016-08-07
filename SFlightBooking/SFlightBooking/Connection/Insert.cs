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
        FlightBookingDataSet fbds;
        string conString = "server=107.180.3.101;database=SheridanProject;uid=sheridan;pwd=password;";
        MySqlConnection con;
        MySqlCommand cmd;
        int result;

        private bool Connect()
        {
            try
            {
                con = new MySqlConnection(conString);
                con.Open();
                return true; //If connection established
            }
            catch
            {
                Console.Beep();
                Console.Write("Could not connect to: " + conString);
                return false;
            }

        }

        

        public void AddCustomer(Customer c)
        {
            int id = GetLastUserId("Customer");

            if (Connect()){
                MessageBox.Show("CONNECTED");
                cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO Customer VALUES(@id, @fName, @lName, @address, @phone, @gender, @birthDate, @enName, @enRelation, @enPhone)";
                cmd.Parameters.AddWithValue("@id", id + 1);
                cmd.Parameters.AddWithValue("@fName", c.FirstName);
                cmd.Parameters.AddWithValue("@lName", c.LastName);
                cmd.Parameters.AddWithValue("@address", c.BirthDate);
                cmd.Parameters.AddWithValue("@phone", c.Gender);
                cmd.Parameters.AddWithValue("@gender", c.Phone);
                cmd.Parameters.AddWithValue("@birthDate", c.BirthDate);
                cmd.Parameters.AddWithValue("@enName", c.EnmergencyName);
                cmd.Parameters.AddWithValue("@enRelation", c.EnmergencyRelationship);
                cmd.Parameters.AddWithValue("@enPhone", c.EnmergencyPhone);

                if(0 < cmd.ExecuteNonQuery())
                {
                    MessageBox.Show("Successfully added!");
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("CONNECTION FAILED");
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
        public int GetLastUserId(string table)
        {
            if (Connect())
            {
                
              
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT uid FROM " + table + " ORDER BY uid DESC LIMIT 1";

                MySqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    return read.GetInt32(0);
                }
                con.Close();
            }

            return 0;

        }

    }


}
