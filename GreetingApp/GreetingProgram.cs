﻿// MIT License
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

// Add Nuget Package: https://www.nuget.org/packages/Russkyc.AttachedUtilities.ConsoleExtensions
using Russkyc.AttachedUtilities.ConsoleExtensions;
using Russkyc.AttachedUtilities.ConsoleExtensions.Types;

namespace GreetingApp;

public static class GreetingProgram
{
    public static void Main()
    {
        new Student(
            "Enter your name: "
                .ToRichOutput()
                .SetForeground(Foreground.Green)
                .GetString(),
            "Enter the total number of your enrolled courses: "
                .ToRichOutput()
                .SetForeground(Foreground.Green)
                .GetInt(),
            "Enter the price of your favorite book: "
                .ToRichOutput()
                .SetForeground(Foreground.Green)
                .GetDouble()
        ).GetInfo();
    }
}

record Student(string Name, int Courses, double BookPrice)
{ 
    public void GetInfo() => Console.WriteLine($"Name: {Name}\nCourses: {Courses}\nPrice of my favorite book: {BookPrice:0.00}");
}