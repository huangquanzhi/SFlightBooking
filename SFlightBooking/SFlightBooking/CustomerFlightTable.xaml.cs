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
    /// Interaction logic for CustomerFlightTable.xaml
    /// </summary>
    public partial class CustomerFlightTable : Window
    {

        List<Flight> flightList = null;
        Customer customerInfo;
        int selectedIndex = -1;

        public CustomerFlightTable()
        {
            InitializeComponent();
            initListView();
        }

        public CustomerFlightTable(Customer c)
        {
            InitializeComponent();
            customerInfo = c;
            initListView();
            listviewLoad();
        }

        private void btn_removeFlight_Click(object sender, RoutedEventArgs e)
        {
            selectedIndex = SelectedIndex();
            if (selectedIndex != -1)
            {
                // TODO: Remove flight
                Flight data = flightList[selectedIndex];

            }
        }

        private void listviewLoad()
        {
            List<Flight> items = new List<Flight>();

            //Load flights from database base on selected customer

            Database db = new Database();
            Select select = new Select();
            List<Flight> temp = new List<Flight>();

            try
            {

                // open connection to retriev flights from database
                MySqlConnection conn = db.CreateConnection();
                conn.Open();
                flightList = select.FlightListByCustomer(db.CreateCommand(conn), customerInfo);
                conn.Close();
                // load to list
                lv_customerFlight.ItemsSource = flightList;
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
            col3.Header = "Duration";
            col3.DisplayMemberBinding = new Binding("Duration");
            col3.Width = 80;
            view.Columns.Add(col3);

            GridViewColumn col4 = new GridViewColumn();
            col4.Header = "Date";
            col4.DisplayMemberBinding = new Binding("Date");
            col4.Width = 100;
            view.Columns.Add(col4);

            GridViewColumn col5 = new GridViewColumn();
            col5.Header = "Time";
            col5.DisplayMemberBinding = new Binding("Time");
            col5.Width = 100;
            view.Columns.Add(col5);

            GridViewColumn col6 = new GridViewColumn();
            col6.Header = "AvailableSeats";
            col6.DisplayMemberBinding = new Binding("AvailableSeats");
            col6.Width = 80;
            view.Columns.Add(col6);

            GridViewColumn col7 = new GridViewColumn();
            col7.Header = "Status";
            col7.DisplayMemberBinding = new Binding("Status");
            col7.Width = 80;
            view.Columns.Add(col7);
            // create view
            lv_customerFlight.View = view;
        }


        private int SelectedIndex()
        {
            return lv_customerFlight.SelectedIndex;
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_viewFlight_Click(object sender, RoutedEventArgs e)
        {
            FlightInfo fi = new FlightInfo(flightList[SelectedIndex()]);
            fi.Show();
        }
    }
}
