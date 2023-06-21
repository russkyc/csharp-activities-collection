using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EmployeeApplicationOld.EmployeeNamespace;

namespace EmployeeApplicationOld
{
    /// <summary>
    /// Interaction logic for frmEmployeeDatabase.xaml
    /// </summary>
    public partial class frmEmployeeDatabase
    {
        // View
        public frmEmployeeDatabase()
        {
            InitializeComponent();
            DataContext = new EmployeeDatabaseViewModel();
        }

        // Business logic for View
        internal partial class EmployeeDatabaseViewModel : ObservableObject
        {
            [ObservableProperty]
            private int _employeeId;

            [ObservableProperty]
            private string? _firstName;

            [ObservableProperty]
            private string? _lastName;

            [ObservableProperty]
            private string? _positon;

            [ObservableProperty]
            private ObservableCollection<Employee> _employees;

            public EmployeeDatabaseViewModel()
            {
                // Items bound to data grid
                Employees = new ObservableCollection<Employee>();
            }

            [RelayCommand]
            void AddEmployee()
            {
                // Adds to Employees collection (Automatically updates data grid)
                Employees.Add(new Employee(EmployeeId, FirstName, LastName, Positon));
            }
        }
    }
}
