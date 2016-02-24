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

namespace HackTrainCompany.Windows
{
    /// <summary>
    /// Interaction logic for DeleteCity.xaml
    /// </summary>
    public partial class DeleteCity : Window
    {
        private AdminLoggedIn parent;

        public DeleteCity()
        {
            this.InitializeComponent();
            this.CmbCityName.ItemsSource = DataAccess.DataAccess.GetAllCities().Select(x => x.Name);
        }

        public DeleteCity(ref AdminLoggedIn parent)
        {
            this.InitializeComponent();
            this.parent = parent;
            this.CmbCityName.ItemsSource = DataAccess.DataAccess.GetAllCities().Select(x => x.Name);
        }

        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnDelete_OnClick(object sender, RoutedEventArgs e)
        {
            if (this.CmbCityName.SelectedItem == null)
            {
                MessageBox.Show("Select a city to delete!");
            }
            else
            {
                try
                {
                    var cityToDel =
                        DataAccess.DataAccess.GetAllCities()
                                  .FirstOrDefault(x => x.Name == this.CmbCityName.SelectedItem.ToString());
                    if (DataAccess.DataAccess.DeleteCity(cityToDel))
                    {
                        this.parent.RefreshGrid();
                        MessageBox.Show(string.Format("Successfully deleted {0}", this.CmbCityName.SelectedItem));
                        this.CmbCityName.ItemsSource = DataAccess.DataAccess.GetAllCities().Select(x => x.Name);
                    }
                else
                    {
                        MessageBox.Show("Something went wrong");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
