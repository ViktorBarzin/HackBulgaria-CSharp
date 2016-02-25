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

namespace HackTrainCompany.Windows.AdminPage.TrainTab
{
    /// <summary>
    /// Interaction logic for DeleteTrain.xaml
    /// </summary>
    public partial class DeleteTrain : Window
    {
        private readonly AdminLoggedIn parent;

        public DeleteTrain(ref AdminLoggedIn parent)
        {
            this.parent = parent;
            this.InitializeComponent();
            this.CmbTrainId.ItemsSource = DataAccess.DataAccess.GetAllTrains().Select(x => x.Id);
        }

        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnDelete_OnClick(object sender, RoutedEventArgs e)
        {
            TrainSet trainToDelete =
                DataAccess.DataAccess.GetAllTrains().FirstOrDefault(x => x.Id == (int)this.CmbTrainId.SelectedItem);
            if (DataAccess.DataAccess.DeleteTrain(trainToDelete))
            {
                parent.RefreshTrainGrind();
                MessageBox.Show(string.Format("Successfully deleted {0}!", this.CmbTrainId.SelectedItem.ToString()));
                this.Close();
            }
            else
            {
                MessageBox.Show("something went wrong!");
            }
        }
    }
}
