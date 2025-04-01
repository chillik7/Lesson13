using System.Windows;
using EmployeeManagement.ViewModels;

namespace EmployeeManagement
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new EmployeeViewModel();
        }
    }
}

