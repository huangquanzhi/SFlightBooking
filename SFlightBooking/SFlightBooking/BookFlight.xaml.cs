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

namespace SFlightBooking {
    /// <summary>
    /// Interaction logic for BookFlight.xaml
    /// </summary>
    public partial class BookFlight : Window {

        List<Customer> customerList;
        List<Flight> flightList;
        int flightIndex = -1;
        int customerIndex = -1;

        public BookFlight() {
            InitializeComponent();

            // create and load data
            initListView();
            listviewLoad();
            customerListLoad();
        }

        private void btn_bookFlight_Click(object sender, RoutedEventArgs e)
        {
            flightIndex = SelectedFlightIndex();
            customerIndex = SelectedCustomerIndex();

            if(flightIndex != -1 && customerIndex != -1)
            {
                // Flight and Customer Selected
            } else
            {
                // Not selected
                MessageBox.Show("Please select both flight and customer to book a flight!");
            }
        }

        private void customerListLoad()
        {
            customerList = new List<Customer>();

            // TODO: Load flights from database base on selected customer

            lb_customers.Items.Add("Test");
        }

        private void listviewLoad()
        {
            flightList= new List<Flight>();

            // TODO: Load flights from database base on selected customer

            lv_flights.ItemsSource = flightList;
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
            col4.Header = "AvailbleSeats";
            col4.DisplayMemberBinding = new Binding("AvailbleSeats");
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
    }
}
