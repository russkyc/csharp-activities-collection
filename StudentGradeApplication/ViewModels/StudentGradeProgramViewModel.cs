// MIT License
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

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace StudentGradeApplication.ViewModels;

partial class StudentGradeProgramViewModel : ObservableObject
{
    [ObservableProperty]
    private string? _name;

    [ObservableProperty]
    private double _subGrade1;
    
    [ObservableProperty]
    private double _subGrade2;
    
    [ObservableProperty]
    private double _subGrade3;
    
    [ObservableProperty]
    private double _subGrade4;
    
    [ObservableProperty]
    private double _subGrade5;

    [ObservableProperty]
    private double _totalGradeAverage;

    [ObservableProperty]
    private string? _statusMessage;

    [RelayCommand]
    private void CalculateGrade()
    {
        TotalGradeAverage = (SubGrade1 + SubGrade2 + SubGrade3 + SubGrade4 + SubGrade5) / 5;
        StatusMessage = $"{Name} {(TotalGradeAverage >= 75 ? "Passed!" : "Failed!")} The general average is {TotalGradeAverage:0.00}";
    }
}