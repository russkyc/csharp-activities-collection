// MIT License
//
// Copyright (c) 2023 Russell Camo
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StudentInfoApplication.ViewModels;
using StudentNamespace;

namespace StudentInfoApplication.Views;

public partial class frmStudentInfo
{
    public frmStudentInfo()
    {
        InitializeComponent();
    }

    internal partial class frmStudentInfoViewModel : ViewModelBase
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
}
