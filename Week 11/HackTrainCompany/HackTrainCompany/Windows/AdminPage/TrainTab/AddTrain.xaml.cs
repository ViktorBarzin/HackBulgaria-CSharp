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
    /// Interaction logic for AddTrain.xaml
    /// </summary>
    public partial class AddTrain : Window
    {
        private readonly AdminLoggedIn parent;

        public AddTrain(ref AdminLoggedIn parent)
        {
            this.parent = parent;
            this.InitializeComponent();
        }

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            int seats;
            if (!int.TryParse(this.TxtSeats.Text,out seats) || String.IsNullOrEmpty(this.TxtDescription.Text))
            {
                MessageBox.Show("Invalid input!");
            }
            else
            {
                TrainSet train = new TrainSet() { Seats = seats, Description = this.TxtDescription.Text, IsFree = true};
                if (DataAccess.DataAccess.AddTrain(train))
                {
                    this.parent.RefreshTrainGrind();
                    MessageBox.Show("Successfully inserted a new train");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong while creating the train!");
                }
            }
        }

        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
