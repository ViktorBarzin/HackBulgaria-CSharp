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

namespace HackTrainCompany.Windows.AdminPage.ScheduleTab
{
    /// <summary>
    /// Interaction logic for DeleteSchedule.xaml
    /// </summary>
    public partial class DeleteSchedule : Window
    {
        private ICollection<CitySet> citySets = DataAccess.DataAccess.GetAllCities();

        private readonly AdminLoggedIn parent;
        public DeleteSchedule(ref AdminLoggedIn parent)
        {
            this.InitializeComponent();
            this.parent = parent;
            this.CmbSchedules.ItemsSource = DataAccess.DataAccess.GetFullSchedule().Select(x => x.Id);
        }

        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnDelete_OnClick(object sender, RoutedEventArgs e)
        {
            if (this.CmbSchedules.SelectedItem == null)
            {
                MessageBox.Show("Select schedule first");
            }
            else
            {
                ScheduleSet tripToDel =
                    DataAccess.DataAccess.GetFullSchedule()
                              .FirstOrDefault(x => x.Id == (int)this.CmbSchedules.SelectedItem);
                if (tripToDel == null)
                {
                    MessageBox.Show("Invalid trip");
                }
                else
                {
                    DataAccess.DataAccess.DeleteTrip(tripToDel);
                    parent.RefreshScheduleGrid();
                    MessageBox.Show("Successfully deleted the trip");
                    this.Close();
                }
            }
        }
    }
}
