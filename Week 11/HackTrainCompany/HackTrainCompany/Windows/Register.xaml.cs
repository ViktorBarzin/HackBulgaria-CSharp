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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
        }

        private void SubmitRegistration(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(this.TxtUsername.Text) 
                || String.IsNullOrEmpty(this.TxtEmail.Text)
                || String.IsNullOrEmpty(this.TxtPassword.Password))
            {
                MessageBox.Show("Username, email and password can not be empty!");
            }
            else if (this.TxtPassword.Password != this.TxtConfirmPassword.Password)
            {
                MessageBox.Show("Passwords are not the same!");
            }
            else
            {
                UserSet userToAdd = new UserSet();
                userToAdd.Username = this.TxtUsername.Text;
                userToAdd.Email = this.TxtEmail.Text;
                userToAdd.PasswordHash = DataAccess.PasswordHash.HashPassword(this.TxtPassword.Password);

                if (!String.IsNullOrEmpty(this.TxtCreditCardNumber.Text))
                {
                    userToAdd.CreditCardNumberHash = DataAccess.PasswordHash.HashPassword(this.TxtCreditCardNumber.Text);
                }
                if (!String.IsNullOrEmpty(this.TxtAddress.Text))
                {
                    userToAdd.Address = this.TxtAddress.Text;
                }
                if (!String.IsNullOrEmpty(this.TxtZipCode.Text))
                {
                    userToAdd.Address = this.TxtZipCode.Text;
                }
                if (!String.IsNullOrEmpty(this.TxtFirstName.Text))
                {
                    userToAdd.Address = this.TxtFirstName.Text;
                }
                if (!String.IsNullOrEmpty(this.TxtLastName.Text))
                {
                    userToAdd.Address = this.TxtLastName.Text;
                }
                if (!String.IsNullOrEmpty(this.TxtTicketId.Text))
                {
                    userToAdd.Address = this.TxtTicketId.Text;
                }
                if (!String.IsNullOrEmpty(this.TxtDiscountcardId.Text))
                {
                    userToAdd.Address = this.TxtDiscountcardId.Text;
                }
                if (DataAccess.DataAccess.AddUser(userToAdd))
                {
                    MessageBox.Show("Registration successful! Use your username and password to login.");
                    MainWindow mainWindow = new MainWindow();
                    this.Close();
                    mainWindow.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Oops, something went wrong in your registration!");
                }
            }
        }
    }
}
