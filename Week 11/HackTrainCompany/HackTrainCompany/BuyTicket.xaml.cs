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

namespace HackTrainCompany
{
    /// <summary>
    /// Interaction logic for BuyTicket.xaml
    /// </summary>
    public partial class BuyTicket : Window
    {
        public BuyTicket()
        {
            this.InitializeComponent();
        }

        private void BtnBack_OnClick(object sender, RoutedEventArgs e)
        {
            UserLoggedIn windows = new UserLoggedIn();
            this.Close();
            windows.Show();
        }

        private void BtnReset_OnClick(object sender, RoutedEventArgs e)
        {
            this.DpcTripDate.SelectedDate = null;
            // TODO : check if reseting works legitamate when data available
            this.CmbStartCity.SelectedItem = null;
            this.CmbDestinationCity.SelectedItem = null;
            this.CmbSeatNumber.SelectedItem = null;
        }

        private void BtnBuyTicket_OnClick(object sender, RoutedEventArgs e)
        {
            if (true)
            {
                MessageBox.Show("You have successfully bought a ticket!");
                UserLoggedIn windows = new UserLoggedIn();
                this.Close();
                windows.Show();
            }
        }
    }
}
