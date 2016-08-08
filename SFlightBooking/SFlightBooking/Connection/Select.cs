///<summary>
///Class contains methods for all Select queries 
/// </summary>
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

        /// <summary>
        /// Queries for all the customers, creates customers, returns list of customer objects
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Queries for all the flightss, creates Flight, returns list of Flight objects
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
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

                        // add flight to list
                        list.Add(new Flight(
                             (string)rd["FlightID"],
                            (string)rd["Airline"],
                            (string)rd["Departure"],
                            (string)rd["Destination"],
                            rd.GetInt32(rd.GetOrdinal("duration")),
                            (string)rd["flightDate"],
                            (string)rd["flightTime"],
                            rd.GetInt32(rd.GetOrdinal("availableSeats")),
                            rd.GetInt32(rd.GetOrdinal("maxSeats")),
                            (string)rd["status"])
                            );
                    }
                }
                // return flight list
                return list;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Returns a list of all the flights booked by a single customer
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public List<Flight> FlightListByCustomer(MySqlCommand cmd, Customer c)
        {

            List<Flight> list = new List<Flight>();

            try
            {
                cmd.CommandText = "SELECT DISTINCT * FROM Ticket t, Customer c, Flight f WHERE c.uid = t.uid AND f.flightID = t.flightID AND c.uid = @uid;";
                cmd.Parameters.AddWithValue("@uid", c.Uid);

                using (MySqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        // add flight to list
                        list.Add(new Flight(
                             (string)rd["FlightID"],
                            (string)rd["Airline"],
                            (string)rd["Departure"],
                            (string)rd["Destination"],
                            rd.GetInt32(rd.GetOrdinal("duration")),
                            (string)rd["flightDate"],
                            (string)rd["flightTime"],
                            rd.GetInt32(rd.GetOrdinal("availableSeats")),
                            rd.GetInt32(rd.GetOrdinal("maxSeats")),
                            (string)rd["status"])
                            );
                    }
                }
                // return flight list
                return list;
            }
            catch
            {
                throw;
            }
        }

    }
}
