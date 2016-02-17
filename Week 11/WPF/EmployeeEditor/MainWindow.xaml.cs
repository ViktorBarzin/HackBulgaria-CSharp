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

namespace EmployeeEditor
{
    //public class MyEventArgs : EventArgs
    //{
    //}

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private EmployeeEditor.HackCompanyDataSet hackCompanyDataSet;

        private EmployeeEditor.HackCompanyDataSetTableAdapters.EmployeeTableAdapter
            hackCompanyDataSetEmployeeTableAdapter;
        //public event EventHandler<MyEventArgs> RowChanged;

        //public MainWindow()
        //{
        //    if (RowChanged != null)
        //    {
        //        RowChanged(this, new MyEventArgs());
        //    }
        //    InitializeComponent();
        //    this.DataContext = this;
        //}

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.hackCompanyDataSet = ((EmployeeEditor.HackCompanyDataSet)(this.FindResource("hackCompanyDataSet")));
            // Load data into the table Employee. You can modify this code as needed.
            this.hackCompanyDataSetEmployeeTableAdapter = new EmployeeEditor.HackCompanyDataSetTableAdapters.EmployeeTableAdapter();
            hackCompanyDataSetEmployeeTableAdapter.Fill(hackCompanyDataSet.Employee);
            System.Windows.Data.CollectionViewSource employeeViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("employeeViewSource")));
            employeeViewSource.View.MoveCurrentToFirst();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                this.hackCompanyDataSetEmployeeTableAdapter.Update(this.hackCompanyDataSet.Employee);
                MessageBox.Show("Changes save Successfully");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
