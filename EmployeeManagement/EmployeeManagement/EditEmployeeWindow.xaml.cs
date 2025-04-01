using System.Windows;
using EmployeeManagement.Models;

namespace EmployeeManagement
{
    public partial class EditEmployeeWindow : Window
    {
        public Employee Employee { get; private set; }

        public EditEmployeeWindow(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
            DataContext = Employee; 
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true; 
        }
    }
}


