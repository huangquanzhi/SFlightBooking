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
