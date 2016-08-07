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

        public Registration()
        {
            InitializeComponent();
        }

        public Registration(Customer c)
        {
            // create form
            InitializeComponent();
            // save customer data in local scope

            // set customer data in form
            try
            {
                tb_firstName.Text = c.FirstName;
                tb_lastName.Text = c.LastName;
                tb_address.Text = c.Address;
                tb_phoneNumber.Text = c.Phone;
                dp_birth.Text = c.BirthDate;
                //TODO: radio set
                tb_enName.Text = c.EnmergencyName;
                tb_enRelation.Text = c.EnmergencyRelationship;
                tb_enPhone.Text = c.EnmergencyPhone;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error init edit form: " + e.Message.ToString());
            }
        }
        Insert dataInsert = new Insert();

        private void btn_register_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string gender = (bool)rb_male.IsChecked ? "Male" : "Female";
                Customer c = new Customer(tb_firstName.Text, tb_lastName.Text, tb_address.Text, tb_phoneNumber.Text, dp_birth.Text, gender, tb_enName.Text, tb_enRelation.Text, tb_enPhone.Text);

                dataInsert.AddCustomer(c);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void clear()
        {
            tb_firstName.Text = "";
            tb_lastName.Text = "";
            tb_address.Text = "";
            tb_phoneNumber.Text = "";
            dp_birth.Text = "";
            //TODO: radio reset
            tb_enName.Text = "";
            tb_enRelation.Text = "";
            tb_enPhone.Text = "";
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            tb_firstName.Text = "";
            tb_lastName.Text = "";
            tb_address.Text = "";
            tb_phoneNumber.Text = "";
            dp_birth.Text = "";
            //TODO: radio reset
            tb_enName.Text = "";
            tb_enRelation.Text = "";
            tb_enPhone.Text = "";
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
