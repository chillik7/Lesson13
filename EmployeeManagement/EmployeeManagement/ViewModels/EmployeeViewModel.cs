using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using EmployeeManagement.Commands;
using EmployeeManagement.Models;

namespace EmployeeManagement.ViewModels
{
    public class EmployeeViewModel
    {
        public ObservableCollection<Employee> Employees { get; set; } = new ObservableCollection<Employee>();
        public ICommand AddEmployeeCommand { get; }
        public ICommand EditEmployeeCommand { get; }
        public ICommand DeleteEmployeeCommand { get; }

        private Employee selectedEmployee;
        public Employee SelectedEmployee
        {
            get => selectedEmployee;
            set
            {
                selectedEmployee = value;
            }
        }

        public EmployeeViewModel()
        {
            AddEmployeeCommand = new RelayCommand(AddEmployee);
            EditEmployeeCommand = new RelayCommand(EditEmployee, CanEditOrDelete);
            DeleteEmployeeCommand = new RelayCommand(DeleteEmployee, CanEditOrDelete);
        }

        private void AddEmployee(object parameter)
        {
            Employees.Add(new Employee { Name = "Новый сотрудник", Position = "Должность" });
        }

        private void EditEmployee(object parameter)
        {
            if (SelectedEmployee != null)
            {
                MessageBox.Show($"Редактирование {SelectedEmployee.Name}", "Редактирование", MessageBoxButton.OK);
            }
        }

        private void DeleteEmployee(object parameter)
        {
            if (SelectedEmployee != null && MessageBox.Show($"Удалить {SelectedEmployee.Name}?", "Подтверждение", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Employees.Remove(SelectedEmployee);
            }
        }

        private bool CanEditOrDelete(object parameter) => SelectedEmployee != null;
    }
}

