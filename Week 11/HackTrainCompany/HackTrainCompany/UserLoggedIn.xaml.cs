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
    using System.Data.SqlClient;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Interaction logic for UserLoggedIn.xaml
    /// </summary>
    public partial class UserLoggedIn : Window
    {
        public UserLoggedIn()
        {
            //this.DataContext = this;
            InitializeComponent();
        }

        private void BtnBuyTicket_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDisplayTrips_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDisplaySchedule_OnClick(object sender, RoutedEventArgs e)
        {
            DateTime? selectedTime = this.DpcDatePicker.SelectedDate;
            if (selectedTime == null)
            {
                MessageBox.Show("Select date first!");
            }
            else
            {
                // 14.10.2016
                // TODO : check if filtering is correct
                // TODO : continue from fixing the date of the trips
                this.DtgDisplayGrid.DataContext = DataAccess.DataAccess.GetFullSchedule().Where(x => (x.StartDate as DateTime?).Value.Year == selectedTime.Value.Year)
                    .Where(y => (y.StartDate as DateTime?).Value.Month == selectedTime.Value.Month);
            }
        }

        //private void FillGrid()
        //{
        //    string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        //    string CmdString = string.Empty;
        //    using (SqlConnection con = new SqlConnection(ConString))
        //    {
        //        SqlDataAdapter sda = new SqlDataAdapter();
        //    DataTable dt = new DataTable("ScheduleSet");
        //    sda.Fill(dt);
        //    this.DtgDisplayGrid.ItemsSource = dt.DefaultView;
        //}
    
    }
}
