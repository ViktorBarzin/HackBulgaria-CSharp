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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HackTrainCompany
{
    using System.Windows.Media.Animation;

    using DataAccess;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //UserSet user = new UserSet
            //{
            //    Username = "Stamat",
            //    Email = "Stamat@gmail.com",
            //    PasswordHash = PasswordHash.HashPassword("mnsamgoten69;)"),
            //    Address = "sofia bg",
            //    IsAdmin = false,
            //    CreditCardNumberHash = PasswordHash.HashPassword("1049694050301030"),
            //    FirstName = "Doncho",
            //    LastName = "Minkov",
            //    ZipCode = 2000
            //};
            //DataAccess.AddUser(user);

            InitializeComponent();

        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            this.Close();
            register.ShowDialog();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            var user = DataAccess.GetAllUsers().FirstOrDefault(x => x.Username.ToLower() == this.TxtUsername.Text.ToLower());

            if (String.IsNullOrEmpty(this.TxtUsername.Text) || String.IsNullOrEmpty(this.TxtPassword.Password))
            {
                MessageBox.Show("Username or password empty!");
            }
            else if(user != null && PasswordHash.ValidatePassword(this.TxtPassword.Password,user.PasswordHash))
            {
                if (user.IsAdmin)
                {
                    AdminLoggedIn window = new AdminLoggedIn();
                    this.Close();
                    window.Show();
                }
                else
                {
                    UserLoggedIn window = new UserLoggedIn();
                    this.Close();
                    window.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Username or password is incorrect!");
            }
        }
    }
}
