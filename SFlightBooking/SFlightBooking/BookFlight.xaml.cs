using MySql.Data.MySqlClient;
using SFlightBooking.Connection;
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
    /// Interaction logic for BookFlight.xaml
    /// </summary>
    public partial class BookFlight : Window
    {

        List<Customer> customerList;
        List<Flight> flightList;
        int flightIndex = -1;
        int customerIndex = -1;

        public BookFlight()
        {
            InitializeComponent();

            // create and load data
            initListView();
            listviewLoad();
            customerListLoad();
        }

        private void btn_bookFlight_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Database db = new Database();
                Insert insert = new Insert();

                flightIndex = SelectedFlightIndex();
                customerIndex = SelectedCustomerIndex();

                // open connection
                MySqlConnection conn = db.CreateConnection();
                conn.Open();

                if (flightIndex != -1 && customerIndex != -1)
                {
                    // booking flight
                    if (insert.BookFlight(db.CreateCommand(conn), customerList[customerIndex], flightList[flightIndex]))
                    {
                        MessageBox.Show("Flight booked!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to book flight!");
                    }

                    // close connection
                    conn.Close();
                }
                else
                {
                    // Not selected
                    MessageBox.Show("Please select both flight and customer to book a flight!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Book flight error: " + ex.Message.ToString());
            }
        }

        private void customerListLoad()
        {
            Database db = new Database();
            Select select = new Select();

            try
            {
                // load customer list from database
                MySqlConnection conn = db.CreateConnection();
                conn.Open();
                customerList = select.CustomerList(db.CreateCommand(conn));
                conn.Close();

                // adding customers to listbox
                foreach (Customer c in customerList)
                {
                    lb_customers.Items.Add(c.FirstName + " " + c.LastName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer List error: " + ex.Message.ToString());
            }


        }

        private void listviewLoad()
        {
            Database db = new Database();
            Select select = new Select();
            List<Flight> temp = new List<Flight>();

            try
            {

                // open connection to retriev flights from database
                MySqlConnection conn = db.CreateConnection();
                conn.Open();
                flightList = select.FlightList(db.CreateCommand(conn));
                conn.Close();

                foreach (Flight f in flightList)
                {
                    // only display available flights
                    if (f.Status == "Available")
                    {
                        temp.Add(f);
                    }
                }

                lv_flights.ItemsSource = temp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Flight List error: " + ex.Message.ToString());
            }

        }

        private void initListView()
        {
            GridView view = new GridView();

            GridViewColumn col1 = new GridViewColumn();
            col1.Header = "Departure";
            col1.DisplayMemberBinding = new Binding("Departure");
            col1.Width = 100;
            view.Columns.Add(col1);

            GridViewColumn col2 = new GridViewColumn();
            col2.Header = "Destination";
            col2.DisplayMemberBinding = new Binding("Destination");
            col2.Width = 100;
            view.Columns.Add(col2);

            GridViewColumn col3 = new GridViewColumn();
            col3.Header = "Date";
            col3.DisplayMemberBinding = new Binding("Date");
            col3.Width = 100;
            view.Columns.Add(col3);

            GridViewColumn col4 = new GridViewColumn();
            col4.Header = "Available";
            col4.DisplayMemberBinding = new Binding("AvailableSeats");
            col4.Width = 100;
            view.Columns.Add(col4);
            // create view
            lv_flights.View = view;
        }

        private int SelectedFlightIndex()
        {
            return lv_flights.SelectedIndex;
        }

        private int SelectedCustomerIndex()
        {
            return lb_customers.SelectedIndex;
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_viewFlight_Click(object sender, RoutedEventArgs e)
        {
            flightIndex = SelectedFlightIndex();
            if (flightIndex > -1)
            {
                FlightInfo fi = new FlightInfo(flightList[flightIndex]);
                fi.Show();
            }

        }

        private void lb_customers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EnableBookFlight();
        }

        private void lv_flights_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EnableBookFlight();
            EnableViewFlight();
        }

        private void EnableViewFlight()
        {
            flightIndex = SelectedFlightIndex();
            // both flight and customer selected
            if (flightIndex != -1)
            {
                btn_viewFlight.IsEnabled = true;
            }
            else
            {
                btn_viewFlight.IsEnabled = false;
            }
        }

        private void EnableBookFlight()
        {
            flightIndex = SelectedFlightIndex();
            customerIndex = SelectedCustomerIndex();
            // both flight and customer selected
            if (flightIndex != -1 && customerIndex != -1)
            {
                btn_bookFlight.IsEnabled = true;
            }
            else
            {
                btn_bookFlight.IsEnabled = false;
            }
        }

    }
}
