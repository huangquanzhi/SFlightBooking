using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFlightBooking.Connection
{
    class Select
    {

        public List<Customer> CustomerList(MySqlCommand cmd)
        {

            List<Customer> list = new List<Customer>();

            try
            {
                cmd.CommandText = "SELECT * FROM Customer";

                using (MySqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {

                        // add customer to list
                        list.Add(new Customer(
                            (rd.GetInt32(0)),
                            (string)rd["FirstName"],
                            (string)rd["LastName"],
                            (string)rd["Address"],
                            (string)rd["Phone"],
                            (string)rd["BirthDate"],
                            (string)rd["Gender"],
                            (string)rd["EnName"],
                            (string)rd["EnRelationship"],
                            (string)rd["EnPhone"])
                            );
                    }
                }
                // return customer list
                return list;
            }
            catch
            {
                throw;
            }
        }

        public List<Flight> FlightList(MySqlCommand cmd)
        {

            List<Flight> list = new List<Flight>();

            try
            {
                cmd.CommandText = "SELECT * FROM Flight";

                using (MySqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {

                        // add customer to list
                        list.Add(new Flight(
                             (string)rd["FlightID"],
                            (string)rd["Airline"],
                            (string)rd["Departure"],
                            (string)rd["Destination"],
                            rd.GetInt32(rd.GetOrdinal("duration")),
                            (string)rd["flightDate"],
                            (string)rd["flightTime"],
                            rd.GetInt32(rd.GetOrdinal("availbleSeats")),
                            rd.GetInt32(rd.GetOrdinal("maxSeats")),
                            (string)rd["status"])
                            );
                    }
                }
                // return customer list
                return list;
            }
            catch
            {
                throw;
            }
        }

    }
}
