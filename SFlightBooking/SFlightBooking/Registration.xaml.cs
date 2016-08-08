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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {

        Customer editCustomer;
        Insert dataInsert;

        public Registration()
        {
            InitializeComponent();
            editCustomer = null;
            dataInsert = new Insert();
        }

        public Registration(Customer c)
        {
            // create form
            InitializeComponent();
            // save customer data in local scope

            // set customer data in form
            try
            {
                // store editing customer
                editCustomer = c;

                tb_firstName.Text = c.FirstName;
                tb_lastName.Text = c.LastName;
                tb_address.Text = c.Address;
                tb_phoneNumber.Text = c.Phone;
                dp_birth.Text = c.BirthDate;
                tb_enName.Text = c.EnmergencyName;
                tb_enRelation.Text = c.EnmergencyRelationship;
                tb_enPhone.Text = c.EnmergencyPhone;

                if (c.Gender == "Male")
                {
                    rb_male.IsChecked = true;
                }
                else if(c.Gender == "Female"){
                    rb_female.IsChecked = true;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error init edit form: " + e.Message.ToString());
            }
        }

        /// <summary>
        /// Register
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_register_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // gender
                string gender = (bool)rb_male.IsChecked ? "Male" : "Female";

                // customer object
                Customer customer = new Customer()
                {
                    FirstName = tb_firstName.Text,
                    LastName = tb_lastName.Text,
                    Address = tb_address.Text,
                    Phone = tb_phoneNumber.Text,
                    BirthDate = dp_birth.Text,
                    Gender = gender,
                    EnmergencyName = tb_enName.Text,
                    EnmergencyRelationship = tb_enRelation.Text,
                    EnmergencyPhone = tb_enPhone.Text
                };

                // Register as new customer
                if (editCustomer == null)
                {
                    // create new database insert
                    Database db = new Database();
                    Insert newCustomer = new Insert();
                    MySqlConnection conn = db.CreateConnection();
                    bool status = false;
                    // open connection
                    try
                    {
                        // customer object, it uses SETTER which will throw exception if empty

                        conn.Open();

                        status = newCustomer.AddCustomer(db.CreateCommand(conn), customer);

                        conn.Close();
                        if (status)
                        {
                            MessageBox.Show("Customer Added");
                            clear();
                        }
                        else
                        {
                            MessageBox.Show("Fail to add customer");
                        }

                    }
                    catch (CustomerException c)
                    {
                        MessageBox.Show("Required: " + c.Message.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database: " + ex.Message.ToString());
                    }

                    // Edit the current customer in database
                }
                else
                {

                    // call update on database
                    Database db = new Database();
                    Update update = new Update();
                    MySqlConnection conn = db.CreateConnection();
                    conn.Open();

                    // set the uid for editing 
                    customer.Uid = editCustomer.Uid;

                    if (update.EditCustomer(db.CreateCommand(conn), customer))
                    {
                        MessageBox.Show("Customer Edited");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Fail to update information.");
                    }
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit error: " + ex.Message.ToString());
            }
        }
        /// <summary>
        /// Clear form
        /// </summary>
        private void clear()
        {
            tb_firstName.Text = "";
            tb_lastName.Text = "";
            tb_address.Text = "";
            tb_phoneNumber.Text = "";
            dp_birth.Text = "";
            rb_male.IsChecked = true;
            tb_enName.Text = "";
            tb_enRelation.Text = "";
            tb_enPhone.Text = "";
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            clear();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
