using MySql.Data.MySqlClient;
using SFlightBooking.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        /// <summary>
        /// Display edit form of selected customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, RoutedEventArgs e)
        {
            selectedIndex = GetSelectedIndex();
            if (selectedIndex != -1)
            {
                // Grab data from List<Customer> using index and create a edit form
                Registration editCustomer = new Registration(customerList[selectedIndex]);
                editCustomer.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Selecte a customer");
            }
        }

        /// <summary>
        /// Deleted customer from database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            selectedIndex = GetSelectedIndex();
            if (selectedIndex != -1)
            {
                try {
                    Database db = new Database();
                    Delete delete = new Delete();
                    MySqlConnection conn = db.CreateConnection();

                    conn.Open();

                    if (delete.RemoveCustomer(db.CreateCommand(conn), customerList[selectedIndex]))
                    {
                        customerList.RemoveAt(selectedIndex);
                        MessageBox.Show("Customer removed!");
                        this.Close();
                    } else
                    {
                        MessageBox.Show("Fail to remove customer from database!");
                    }
                    conn.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show("Delete error: " + ex.Message.ToString());
                }
            }
        }

        /// <summary>
        /// Display customers flight table form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_viewRecord_Click(object sender, RoutedEventArgs e)
        {
            selectedIndex = GetSelectedIndex();
            if (selectedIndex != -1)
            {
                CustomerFlightTable flightRecord = new CustomerFlightTable(customerList[selectedIndex]);
                flightRecord.Show();
                this.Close();
            } else
            {
                MessageBox.Show("Please Selecte a customer");
            }
        }

        /// <summary>
        ///  load customer list from database
        /// </summary>
        private void listviewLoad()
        {
            Database db = new Database();
            Select select = new Select();

            try
            {

                MySqlConnection conn = db.CreateConnection();
                conn.Open();
                customerList = select.CustomerList(db.CreateCommand(conn));
                conn.Close();

                lv_customerList.ItemsSource = customerList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer List error: " + ex.Message.ToString());
            }
        }

        /// <summary>
        /// Create a list view of customer
        /// </summary>
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

        /// <summary>
        /// Selected index of customer list
        /// </summary>
        /// <returns>Index of selected customer</returns>
        public int GetSelectedIndex()
        {
            return lv_customerList.SelectedIndex;
        }

        /// <summary>
        /// Customer selection changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_customerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(GetSelectedIndex() != -1)
            {
                btn_update.IsEnabled = true;
                btn_delete.IsEnabled = true;
                btn_viewRecord.IsEnabled = true;
            } else
            {
                btn_update.IsEnabled = false;
                btn_delete.IsEnabled = false;
                btn_viewRecord.IsEnabled = false;
            }
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
