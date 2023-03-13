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

// Install Nuget Package: Russkyc.AttachedUtilities.ConsoleExtensions
// Documentation: https://www.nuget.org/packages/Russkyc.AttachedUtilities.ConsoleExtensions/

// Add Dependency
using Russkyc.AttachedUtilities.ConsoleExtensions;

namespace ComputerAverageApp;

public static class ComputerAverageProgram
{
    public static void Main(string[] args)
    {
        var average = "Enter 5 Grades separated by spaces: "
            .ToRichOutput()
            .GetDoubleCollection()
            .Average();
        
        $"The Average is {average:0.00} and Round off to {Math.Round(average)}"
            .ToRichOutput()
            .WriteLine();
    }
}