using System.Windows;
using StudentRegistrationApplication.ViewModels;
using StudentRegistrationApplication.Views;

namespace StudentRegistrationApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            InitializeComponent();
            
            var view = new StudentRegistrationView
            {
                DataContext = new RegistrationViewModel()
            };
            
            view.Show();
        }
    }
}