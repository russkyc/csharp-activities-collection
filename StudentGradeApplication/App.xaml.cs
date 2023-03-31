using System.Windows;
using StudentGradeApplication.ViewModels;
using StudentGradeApplication.Views;

namespace StudentGradeApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            InitializeComponent();
            base.OnStartup(e);

            var view = new StudentGradeProgramView
            {
                DataContext = new StudentGradeProgramViewModel()
            };
            
            view.Show();
        }
    }
}