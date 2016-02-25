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

namespace HackTrainCompany.Windows.AdminPage
{
    /// <summary>
    /// Interaction logic for EditTrain.xaml
    /// </summary>
    public partial class EditTrain : Window
    {
        private readonly ICollection<TrainSet> allTrains = DataAccess.DataAccess.GetAllTrains();

        private AdminLoggedIn parent;

        public EditTrain(ref AdminLoggedIn parent)
        {
            this.parent = parent;
            this.InitializeComponent();
            this.CmbTrainId.ItemsSource = DataAccess.DataAccess.GetAllTrains().Select(x => x.Id);
        }

        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnEdit_OnClick(object sender, RoutedEventArgs e)
        {
            int oldTrainId = (int)this.CmbTrainId.SelectedItem;
            int seats;
            if (String.IsNullOrEmpty(this.TxtDescription.Text) || String.IsNullOrEmpty(this.TxtSeats.Text) || !int.TryParse(this.TxtSeats.Text,out seats))
            {
                MessageBox.Show("Invalid input data!");
                return;
            }

            TrainSet updatedTrain = new TrainSet() {Seats = int.Parse(this.TxtSeats.Text),Description = this.TxtDescription.Text, IsFree = (bool)this.ChkIsFree.IsChecked};
            if (DataAccess.DataAccess.EditTrain(oldTrainId, updatedTrain))
            {
                parent.RefreshTrainGrind();
                MessageBox.Show("Successfully updated the train!");
            }
            else
            {
                MessageBox.Show("Something went wrong while updating the train");
            }
        }

        private void CmbTrainId_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TrainSet currentTrain = this.allTrains.FirstOrDefault(x => x.Id == int.Parse(this.CmbTrainId.SelectedItem.ToString()));
            if (currentTrain == null)
            {
                return;
            }

            this.TxtSeats.Text = currentTrain.Seats.ToString();
            this.TxtDescription.Text = currentTrain.Description;
            this.ChkIsFree.IsChecked = currentTrain.IsFree;
        }
    }
}
