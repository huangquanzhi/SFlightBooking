///<summary></summary>


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFlightBooking
{


    public class Flight
    {
        private string flightID;
        private string airline;
        private string departure;
        private string destination;
        private int duration;
        private string date;
        private string time;
        private int availableSeats;
        private int maxSeats;
        private string status;
        private double price;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="flightID"></param>
        /// <param name="airline"></param>
        /// <param name="departure"></param>
        /// <param name="destination"></param>
        /// <param name="duration"></param>
        /// <param name="date"></param>
        /// <param name="time"></param>
        /// <param name="availableSeats"></param>
        /// <param name="maxSeats"></param>
        /// <param name="status"></param>
        /// <param name="price"></param>
        public Flight(string flightID, string airline, string departure, string destination, int duration, string date, string time, int availableSeats, int maxSeats, string status, double price)
        {
            this.flightID = flightID;
            this.airline = airline;
            this.departure = departure;
            this.destination = destination;
            this.duration = duration;
            this.date = date;
            this.time = time;
            this.availableSeats = availableSeats;
            this.maxSeats = maxSeats;
            this.status = status;
            this.price = price;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="flightID"></param>
        /// <param name="airline"></param>
        /// <param name="departure"></param>
        /// <param name="destination"></param>
        /// <param name="duration"></param>
        /// <param name="date"></param>
        /// <param name="time"></param>
        /// <param name="availableSeats"></param>
        /// <param name="maxSeats"></param>
        /// <param name="status"></param>
        public Flight(string flightID, string airline, string departure, string destination, int duration, string date, string time, int availableSeats, int maxSeats, string status)
        {
            this.flightID = flightID;
            this.airline = airline;
            this.departure = departure;
            this.destination = destination;
            this.duration = duration;
            this.date = date;
            this.time = time;
            this.availableSeats = availableSeats;
            this.maxSeats = maxSeats;
            this.status = status;
        }

        /// <summary>
        /// Flight id
        /// </summary>
        public string FlightID
        {
            get
            {
                return flightID;
            }

            set
            {
                flightID = value;
            }
        }

        /// <summary>
        /// Airline 
        /// </summary>
        public string Airline
        {
            get
            {
                return airline;
            }

            set
            {
                airline = value;
            }
        }

        /// <summary>
        /// Departure
        /// </summary>
        public string Departure
        {
            get
            {
                return departure;
            }

            set
            {
                departure = value;
            }
        }

        /// <summary>
        /// Destination
        /// </summary>
        public string Destination
        {
            get
            {
                return destination;
            }

            set
            {
                destination = value;
            }
        }

        /// <summary>
        /// Duration
        /// </summary>
        public int Duration
        {
            get
            {
                return duration;
            }

            set
            {
                duration = value;
            }
        }

        /// <summary>
        /// Date
        /// </summary>
        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        /// <summary>
        /// Time
        /// </summary>
        public string Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }

        /// <summary>
        /// AvailableSeats
        /// </summary>
        public int AvailableSeats
        {
            get
            {
                return availableSeats;
            }

            set
            {
                availableSeats = value;
            }
        }

        /// <summary>
        /// Max Seats
        /// </summary>
        public int MaxSeats
        {
            get
            {
                return maxSeats;
            }

            set
            {
                maxSeats = value;
            }
        }

        /// <summary>
        /// Status
        /// </summary>
        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        /// <summary>
        /// Price
        /// </summary>
        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }
}
