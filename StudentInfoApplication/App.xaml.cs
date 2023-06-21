using System;
using StudentInfoApplication.ViewModels;
using StudentInfoApplication.Views;

namespace StudentInfoApplication;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{
    /// <summary>
    /// Application Entry for StudentInfoApplication
    /// </summary>
    public App()
    {
        InitializeComponent();
        var view = new frmStudentInfo { DataContext = Activator.CreateInstance<frmStudentInfoViewModel>() };
        view.Show();
    }
}
