﻿// MIT License
//
// Copyright (c) $today.year Russell Camo (Russkyc)
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

using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using org.russkyc.moderncontrols;

namespace StudentRegistrationApplication.Views
{
    /// <summary>
    /// Interaction logic for StudentRegistrationView.xaml
    /// </summary>
    public partial class StudentRegistrationView : ModernWindow
    {
        public StudentRegistrationView()
        {
            DataContext = new RegistrationViewModel();
        }
    }

    public partial class RegistrationViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? _firstName;

        [ObservableProperty]
        private string? _middleName;

        [ObservableProperty]
        private string? _lastName;

        [ObservableProperty]
        private bool _male;

        [ObservableProperty]
        private bool _female;

        [ObservableProperty]
        private ObservableCollection<int>? _day;

        [ObservableProperty]
        private ObservableCollection<int>? _month;

        [ObservableProperty]
        private ObservableCollection<int>? _year;

        [ObservableProperty]
        private ObservableCollection<string>? _programs;

        [ObservableProperty]
        private int _selectedDay;

        [ObservableProperty]
        private int _selectedMonth;

        [ObservableProperty]
        private int _selectedYear;

        [ObservableProperty]
        private int _selectedProgram;

        [ObservableProperty]
        private string _imageSource;

        public RegistrationViewModel()
        {
            SelectedDay = 0;
            SelectedMonth = 0;
            SelectedYear = 0;
            SelectedProgram = 0;

            Day = new ObservableCollection<int>();
            Month = new ObservableCollection<int>();
            Year = new ObservableCollection<int>();
            Programs = new ObservableCollection<string>();

            for (int i = 1; i <= 30; i++)
                Day.Add(i);
            for (int i = 1; i <= 12; i++)
                Month.Add(i);
            for (int i = 1900; i <= 2022; i++)
                Year.Add(i);

            foreach (
                string course in new ArrayList
                {
                    "Bachelor of Science in Computer Science",
                    "Bachelor of Science in Information Technology",
                    "Bachelor of Science in Information Systems",
                    "Bachelor of Science in Computer Engineering"
                }
            )
                Programs.Add(course);
        }

        [RelayCommand]
        void Register()
        {
            var name = $"{FirstName} {MiddleName} {LastName}";
            var gender = Male
                ? "Male"
                : Female
                    ? "Female"
                    : "Prefer Not to Say";
            var dateOfBirth = $"{Day![SelectedDay]}/{Month![SelectedMonth]}/{Year![SelectedYear]}";
            var program = Programs![SelectedProgram];

            OpenRegistrationDialog(name, program);
            OpenRegistrationDialog(name, gender, dateOfBirth, program);
        }

        [RelayCommand]
        void UploadImage()
        {
            var imagePicker = new OpenFileDialog
            {
                Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
            };

            if (imagePicker.ShowDialog() == true)
            {
                ImageSource = imagePicker.FileName;
            }
        }

        void OpenRegistrationDialog(string name, string program)
        {
            for (int i = 0; i < 2; i++)
            {
                Task.Run(async () =>
                {
                    MessageBox.Show($"Student Name: {name}{Environment.NewLine}Program: {program}");
                    await Task.Delay(500);
                });
            }
        }

        void OpenRegistrationDialog(string name, string gender, string dateOfBirth, string program)
        {
            Task.Run(async () =>
            {
                MessageBox.Show(
                    $"Student Name: {name}{Environment.NewLine}Gender: {gender}{Environment.NewLine}Date of Birth: {dateOfBirth}{Environment.NewLine}Program: {program}"
                );
                await Task.Delay(500);
            });
        }
    }
}
