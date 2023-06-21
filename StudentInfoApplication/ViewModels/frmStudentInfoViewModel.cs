using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StudentNamespace;

namespace StudentInfoApplication.ViewModels;

public partial class frmStudentInfoViewModel : ViewModelBase
{
    [ObservableProperty]
    private string? _welcomeMessage;

    [ObservableProperty]
    private string _studentId;

    [ObservableProperty]
    private string _firstName;

    [ObservableProperty]
    private string _lastName;

    [ObservableProperty]
    private ObservableCollection<StudentInfo> _students;

    [ObservableProperty]
    private ObservableCollection<string> _studentIds;

    [ObservableProperty]
    private ObservableCollection<string> _studentFirstNames;

    [ObservableProperty]
    private ObservableCollection<string> _studentLastNames;

    public frmStudentInfoViewModel()
    {
        WelcomeMessage = "Welcome to your MVVM App!";
        Students = new ObservableCollection<StudentInfo>();
        StudentIds = new ObservableCollection<string>();
        StudentFirstNames = new ObservableCollection<string>();
        StudentLastNames = new ObservableCollection<string>();
    }

    [RelayCommand]
    void AddStudent()
    {
        var student = new StudentInfo(StudentId, LastName, FirstName);
        Students.Add(student);
        StudentIds.Add(student.StudentId);
        StudentLastNames.Add(student.LastName);
        StudentFirstNames.Add(student.FirstName);
        ClearFields();
    }

    void ClearFields()
    {
        StudentId = string.Empty;
        FirstName = string.Empty;
        LastName = string.Empty;
    }
}
