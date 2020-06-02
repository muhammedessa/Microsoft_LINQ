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
using System.Configuration;
using System.Data.Linq;

namespace WpfAppLinq
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DataClasses1DataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager
                .ConnectionStrings["WpfAppLinq.Properties.Settings.EmployeesDBConnectionString"]
                .ConnectionString;
            
            dataContext = new DataClasses1DataContext(connectionString);
            ReadDataEmployees();
            //  UpdateDataEmployee();
           // DeleteDataEmployee();
        }

        public void ReadDataEmployees()
        {
            datagridView1.ItemsSource = dataContext.Employees;
        }

        private void ClickToSaveData(object sender, RoutedEventArgs e)
        {
            datagridView1.DataContext = dataContext.Employees;
            Employee emp = new Employee();
            emp.FirstName = firstNameText.Text;
            emp.LastName = lastNameText.Text;
            dataContext.Employees.InsertOnSubmit(emp);
            dataContext.SubmitChanges();
            
        }

        public void UpdateDataEmployee()
        {
            Employee empUpdate = dataContext.Employees.FirstOrDefault(em => em.FirstName == "sssss");
            empUpdate.FirstName = "Fatima";
            dataContext.SubmitChanges();
        }

        public void DeleteDataEmployee()
        {
            Employee empDelete = dataContext.Employees.FirstOrDefault(em => em.FirstName == "First name");
            dataContext.Employees.DeleteOnSubmit(empDelete);
            dataContext.SubmitChanges();
        }
    }
}
