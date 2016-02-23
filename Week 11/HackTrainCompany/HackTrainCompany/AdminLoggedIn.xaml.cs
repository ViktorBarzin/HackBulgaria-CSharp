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

    /// <summary>
    /// Interaction logic for AdminLoggedIn.xaml
    /// </summary>
    public partial class AdminLoggedIn : Window
    {
        public AdminLoggedIn()
        {
            InitializeComponent();
        }

        private void BtnGetAllCities_OnClick(object sender, RoutedEventArgs e)
        {
            this.DtgAllCities.ItemsSource = DataAccess.DataAccess.GetAllCities();
        }

        private void BtnAddCity_OnClick(object sender, RoutedEventArgs e)
        {
            AddCity window = new AddCity();
            window.Show();
        }

        private void BtnDeleteCity_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
