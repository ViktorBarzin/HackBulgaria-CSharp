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

    /// <summary>
    /// Interaction logic for AdminLoggedIn.xaml
    /// </summary>
    public partial class AdminLoggedIn : Window
    {
        public AdminLoggedIn()
        {
            this.InitializeComponent();
        }

        private void BtnGetAllCities_OnClick(object sender, RoutedEventArgs e)
        {
            this.DtgAllCities.ItemsSource = DataAccess.GetAllCities();
        }

        private void BtnAddCity_OnClick(object sender, RoutedEventArgs e)
        {
            AdminLoggedIn currentWindow = this;
            AddCity window = new AddCity(ref currentWindow);
            window.Show();
        }

        private void BtnDeleteCity_OnClick(object sender, RoutedEventArgs e)
        {
            AdminLoggedIn currentWindow = this;
            DeleteCity window = new DeleteCity(ref currentWindow);
            window.Show();
        }

        /// <summary>
        /// Refreshes datagrid items
        /// </summary>
        public void RefreshGrid()
        {
            this.DtgAllCities.ItemsSource = DataAccess.GetAllCities();
        }
    }
}
