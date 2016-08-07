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

    }
}
