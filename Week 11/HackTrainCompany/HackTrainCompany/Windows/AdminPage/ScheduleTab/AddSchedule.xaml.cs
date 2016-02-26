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
    /// Interaction logic for AddSchedule.xaml
    /// </summary>
    public partial class AddSchedule : Window
    {
        private readonly AdminLoggedIn parent;

        public AddSchedule(ref AdminLoggedIn parent)
        {
            this.InitializeComponent();
            this.parent = parent;
        }

        private void BtnCancel_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            int ticketId;
            int travelTime;
            int trainId;
            DateTime startDate;
            if (String.IsNullOrEmpty(this.TxtEndCityId.Text)
                || String.IsNullOrEmpty(this.TxtStartCityId.Text)
                || String.IsNullOrEmpty(this.TxtStartDate.Text)
                || String.IsNullOrEmpty(this.TxtTicketId.Text)
                || String.IsNullOrEmpty(this.TxtTrainId.Text)
                || String.IsNullOrEmpty(this.TxtTravelTime.Text))
            {
                MessageBox.Show("All fields must be filled");
            }
            else if(int.TryParse(this.TxtTrainId.Text,out trainId)
                && int.TryParse(this.TxtTicketId.Text,out ticketId)
                && int.TryParse(this.TxtTravelTime.Text,out travelTime)
                && DateTime.TryParse(this.TxtStartDate.Text,out startDate))
            {
                CitySet startCity =
                    DataAccess.DataAccess.GetAllCities().FirstOrDefault(x => x.Name == this.TxtStartCityId.Text);
                CitySet endCity =
                    DataAccess.DataAccess.GetAllCities().FirstOrDefault(x => x.Name == this.TxtEndCityId.Text);
                ScheduleSet newSchedule = new ScheduleSet() {TicketId = ticketId, TrainId = trainId,TravelTime = travelTime, StartCityId = startCity.Id,EndCityId = endCity.Id,StartDate = startDate};
                if (DataAccess.DataAccess.AddTrip(newSchedule))
                {
                    this.parent.RefreshScheduleGrid();
                    MessageBox.Show("Successfully added a new trip");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
        }
    }
}
