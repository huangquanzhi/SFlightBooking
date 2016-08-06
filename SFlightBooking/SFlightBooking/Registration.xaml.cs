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

        private void btn_register_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // customer object
                Customer reg = new Customer(
                    tb_firstName.Text,
                    tb_lastName.Text,
                    tb_address.Text,
                    tb_phoneNumber.Text,
                    dp_birth.Text,
                    "male",
                    tb_enName.Text,
                    tb_enRelation.Text,
                    tb_enPhone.Text
                    );


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
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

        }
    }
}
