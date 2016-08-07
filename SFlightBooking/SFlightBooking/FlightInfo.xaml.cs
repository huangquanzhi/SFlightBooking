using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SFlightBooking
{
    /// <summary>
    /// Interaction logic for FlightInfo.xaml
    /// </summary>
    public partial class FlightInfo : Window
    {

        private Flight flightInfo;

        public FlightInfo()
        {
            InitializeComponent();
        }

        public FlightInfo(Flight f)
        {
            flightInfo = f;
            InitializeComponent();
            loadForm();
        }

        public void loadForm()
        {
            if (flightInfo != null)
            {
                tb_location.Text = flightInfo.Departure;
                tb_destination.Text = flightInfo.Destination;
                tb_airline.Text = flightInfo.Airline;
                tb_duration.Text = flightInfo.Duration + " minutes";
                dp_date.Text = flightInfo.Date;
                tp_time.Text = flightInfo.Time;
                tb_airline.Text = "" + flightInfo.AvailbleSeats;
                tb_capacity.Text = "" + flightInfo.MaxSeats;
                switch (flightInfo.Status)
                {
                    case "Availble":
                        rb_available.IsChecked = true;
                        break;
                    case "InProgress":
                        rb_progress.IsChecked = true;
                        break;
                    case "Completed":
                        rb_completed.IsChecked = true;
                        break;
                }
            }
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
