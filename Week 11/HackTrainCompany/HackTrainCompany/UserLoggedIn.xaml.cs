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
    /// Interaction logic for UserLoggedIn.xaml
    /// </summary>
    public partial class UserLoggedIn : Window
    {
        public UserLoggedIn()
        {
            InitializeComponent();
            this.CmbCityA.ItemsSource = DataAccess.DataAccess.GetAllCities().Select(x => x.Name);
            this.CmbCityB.ItemsSource = DataAccess.DataAccess.GetAllCities().Select(x => x.Name);
        }

        private void BtnBuyTicket_OnClick(object sender, RoutedEventArgs e)
        {
            BuyTicket windows = new BuyTicket();
            this.Close();
            windows.Show();
        }

        private void BtnDisplayTrips_OnClick(object sender, RoutedEventArgs e)
        {
            if (this.CmbCityA.SelectedItem == null)
            {
                MessageBox.Show("Select the first city!");
            }
            if (this.CmbCityB.SelectedItem == null)
            {
                MessageBox.Show("Select the second city!");
            }
            else
            {
                CitySet cityA = DataAccess.DataAccess.GetAllCities().FirstOrDefault(x => x.Name == CmbCityA.SelectedItem.ToString());

                CitySet cityB = DataAccess.DataAccess.GetAllCities().FirstOrDefault(x => x.Name == CmbCityB.SelectedItem.ToString());

                if (cityA == null || cityB == null)
                {
                    MessageBox.Show("Select a city first!");
                }
                else
                {
                    var allTripsFromAtoB = DataAccess.DataAccess.GetFullSchedule()
                          .Where(x => x.StartCityId == cityA.Id)
                          .Where(y => y.EndCityId == cityB.Id)
                          .OrderBy(z => z.Id);

                    StringBuilder allTrips = new StringBuilder();

                    foreach (var trip in allTripsFromAtoB)
                    {
                        allTrips.Append(string.Format("trip id: {0}, trip start date: {1}, train id: {2}", trip.Id, trip.StartDate, trip.TrainId)).AppendLine();
                    }

                    MessageBox.Show(allTrips.ToString());
                }

            }
        }

        private void BtnDisplaySchedule_OnClick(object sender, RoutedEventArgs e)
        {
            DateTime? selectedTime = this.DpcDatePicker.SelectedDate;
            if (selectedTime == null)
            {
                MessageBox.Show("Select date first!");
            }
            else
            {
                var dataGridContext = DataAccess.DataAccess.GetFullSchedule()
                              .Where(x => x.StartDate.Value.Date.ToShortDateString() == selectedTime.Value.Date.ToShortDateString());
                this.DtgDisplayGrid.DataContext = dataGridContext;
            }
        }

        private void BtnLogout_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
        }
    }
}
