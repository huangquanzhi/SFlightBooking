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
    /// Interaction logic for CustomersList.xaml
    /// </summary>
    public partial class CustomersList : Window
    {

        List<Customer> customerList;
        int selectedIndex = -1;

        public CustomersList()
        {
            InitializeComponent();
            initListView();
            listviewLoad();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_update_Click(object sender, RoutedEventArgs e)
        {
            selectedIndex = GetSelectedIndex();
            if (selectedIndex != -1)
            {
                // TODO: Grab data from List<Customer> using index and create a edit form
                Registration editCustomer = new Registration(new Customer("1", "1", "1", "1", "1", "1", "1", "1", "1"));
                editCustomer.Show();
            } else
            {
                MessageBox.Show("Please Selecte a customer");
            }
        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            selectedIndex = GetSelectedIndex();
            if (selectedIndex != -1)
            {

            }
        }

        private void btn_viewRecord_Click(object sender, RoutedEventArgs e)
        {
            selectedIndex = GetSelectedIndex();
            if (selectedIndex != -1)
            {

            }
        }

        private void btn_book_Click(object sender, RoutedEventArgs e)
        {
            selectedIndex = GetSelectedIndex();
            if (selectedIndex != -1)
            {

            }
        }

        private void listviewLoad()
        {
            List<Customer> items = new List<Customer>();
            items.Add(new Customer()
            {
                FirstName = "First",
                LastName = "Second",
                Address = "Address",
                Phone = "Phone",
                BirthDate = "Birth",
                Gender = "Male",
                EnmergencyName = "En",
                EnmergencyRelationship = "Re",
                EnmergencyPhone = "P"
            }
                );
            lv_customerList.ItemsSource = items;
        }

        private void initListView()
        {
            GridView view = new GridView();

            GridViewColumn col1 = new GridViewColumn();
            col1.Header = "First Name";
            col1.DisplayMemberBinding = new Binding("FirstName");
            col1.Width = 100;
            view.Columns.Add(col1);

            GridViewColumn col6 = new GridViewColumn();
            col6.Header = "Last Name";
            col6.DisplayMemberBinding = new Binding("LastName");
            col6.Width = 100;
            view.Columns.Add(col6);

            GridViewColumn col2 = new GridViewColumn();
            col2.Header = "Address";
            col2.DisplayMemberBinding = new Binding("Address");
            col2.Width = 200;
            view.Columns.Add(col2);

            GridViewColumn col3 = new GridViewColumn();
            col3.Header = "Phone";
            col3.DisplayMemberBinding = new Binding("Phone");
            col3.Width = 100;
            view.Columns.Add(col3);


            GridViewColumn col4 = new GridViewColumn();
            col4.Header = "Birth";
            col4.DisplayMemberBinding = new Binding("BirthDate");
            col4.Width = 100;
            view.Columns.Add(col4);

            GridViewColumn col5 = new GridViewColumn();
            col5.Header = "Gender";
            col5.DisplayMemberBinding = new Binding("Gender");
            col5.Width = 60;
            view.Columns.Add(col5);

            // create view
            lv_customerList.View = view;

        }

        public int GetSelectedIndex()
        {
            return lv_customerList.SelectedIndex;
        }
    }
}
