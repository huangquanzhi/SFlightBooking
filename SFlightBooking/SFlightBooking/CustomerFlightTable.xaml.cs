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
    /// Interaction logic for CustomerFlightTable.xaml
    /// </summary>
    public partial class CustomerFlightTable : Window {

        Customer customerInfo;

        public CustomerFlightTable() {
            InitializeComponent();
        }

        public CustomerFlightTable(Customer c)
        {
            customerInfo = c;
        }

        private List<Flight> loadCustomerFlight()
        {
            // TODO: user customer info to retrive data from database
            return new List<Flight>();
        }

    }
}
