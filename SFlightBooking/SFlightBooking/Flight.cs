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
        private string departure;
        private string destination;
        private string duration;
        private string date;
        private string time;
        private int availbleSeats;
        private string status;

        public Flight(string flightID, string departure, string destination, string duration, string date, string time, int availbleSeats, string status)
        {
            this.flightID = flightID;
            this.departure = departure;
            this.destination = destination;
            this.duration = duration;
            this.date = date;
            this.time = time;
            this.availbleSeats = availbleSeats;
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

        public string Duration
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

        public int AvailbleSeats
        {
            get
            {
                return availbleSeats;
            }

            set
            {
                availbleSeats = value;
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
    }
}
