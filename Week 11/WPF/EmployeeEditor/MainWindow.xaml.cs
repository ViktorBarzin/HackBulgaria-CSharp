namespace EmployeeEditor
{
    using System;
    using System.Windows;
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
                MessageBox.Show("Changes saved successfully");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
