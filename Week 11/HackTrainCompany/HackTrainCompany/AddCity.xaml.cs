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
    /// Interaction logic for AddCity.xaml
    /// </summary>
    public partial class AddCity : Window
    {
        public AddCity()
        {
            InitializeComponent();
        }

        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnInsert_OnClick(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(this.TxbName.Text))
            {
                MessageBox.Show("Please enter city name!");
            }
            else
            {
                try
                {
                    DataAccess.DataAccess.AddCity(new CitySet() { Name = this.TxbName.Text });
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
