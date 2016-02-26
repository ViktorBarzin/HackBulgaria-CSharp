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
    using System.Data;

    using DataAccess;

    using HackTrainCompany.Windows;
    using HackTrainCompany.Windows.AdminPage;
    using HackTrainCompany.Windows.AdminPage.ScheduleTab;
    using HackTrainCompany.Windows.AdminPage.TrainTab;

    /// <summary>
    /// Interaction logic for AdminLoggedIn.xaml
    /// </summary>
    public partial class AdminLoggedIn : Window
    {
        public AdminLoggedIn()
        {
            this.InitializeComponent();
        }

        // City logic
        private void BtnGetAllCities_OnClick(object sender, RoutedEventArgs e)
        {
            this.DtgAllCities.ItemsSource = DataAccess.GetAllCities();
        }

        private void BtnAddCity_OnClick(object sender, RoutedEventArgs e)
        {
            AdminLoggedIn currentWindow = this;
            AddCity window = new AddCity(ref currentWindow);
            window.ShowDialog();
        }

        private void BtnDeleteCity_OnClick(object sender, RoutedEventArgs e)
        {
            AdminLoggedIn currentWindow = this;
            DeleteCity window = new DeleteCity(ref currentWindow);
            window.ShowDialog();
        }

        // Train logic
        private void BtnGetAllTrains_OnClick(object sender, RoutedEventArgs e)
        {
            this.DtgAllTrains.ItemsSource = DataAccess.GetAllTrains();
        }

        private void BtnAddTrain_OnClick(object sender, RoutedEventArgs e)
        {
            AdminLoggedIn adminWindow = this;
            AddTrain window = new AddTrain(ref adminWindow);
            window.ShowDialog();
        }

        private void BtnEditTrain_OnClick(object sender, RoutedEventArgs e)
        {
            AdminLoggedIn parent = this;
            EditTrain window = new EditTrain(ref parent);
            window.ShowDialog();
        }

        private void BtnDeleteTrain_OnClick(object sender, RoutedEventArgs e)
        {
            AdminLoggedIn adminLogged = this;
            DeleteTrain window = new DeleteTrain(ref adminLogged);
            window.ShowDialog();
        }

        /// <summary>
        /// Refreshes datagrid items
        /// </summary>
        public void RefreshCityGrid()
        {
            this.DtgAllCities.ItemsSource = DataAccess.GetAllCities();
        }

        public void RefreshTrainGrind()
        {
            this.DtgAllTrains.ItemsSource = DataAccess.GetAllTrains();
        }

        private void BtnGetFullSchedule_OnClick(object sender, RoutedEventArgs e)
        {
            this.DtgAllSchedules.ItemsSource = DataAccess.GetFullSchedule();
            this.DtgAllSchedules.Columns.Add(new DataGridTextColumn());
        }

        private void BtnAddSchedule_OnClick(object sender, RoutedEventArgs e)
        {
            AdminLoggedIn parent = this;
            AddSchedule window = new AddSchedule(ref parent);
            window.ShowDialog();
        }

        private void BtnDeleteSchedule_OnClick(object sender, RoutedEventArgs e)
        {
            AdminLoggedIn parent = this;
            DeleteSchedule window = new DeleteSchedule(ref parent);
            window.ShowDialog();
        }

        public void RefreshScheduleGrid()
        {
            this.DtgAllSchedules.ItemsSource = DataAccess.GetFullSchedule();
        }

        private void Hyperlink_OnClick(object sender, RoutedEventArgs e)
        {
           UserLoggedIn window = new UserLoggedIn();
            window.ShowDialog();
        }
    }
}
