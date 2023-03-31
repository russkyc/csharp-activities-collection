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

namespace MathApp;

public static class MathProgram
{
    public static void Main(string[] args)
    {
        while (true)
        {
            typeof(MathProgram)
                .GetMethods()
                .ToList()
                .ForEach(
                    f => {
                        if (f.ReturnType == typeof(double)) Console.WriteLine($"{f.Name[3]} - {f.Name}");
                    });
            var selection = "Enter Selection: "
                .ToRichOutput()
                .GetString();
            
            if (string.Equals(selection,"S", StringComparison.InvariantCultureIgnoreCase)) 
                Console.WriteLine(GetSquareRoot("Enter num: "
                    .ToRichOutput()
                    .GetInt()));
            
            if (string.Equals(selection,"P", StringComparison.InvariantCultureIgnoreCase))
                Console.WriteLine(GetPower("Enter num1: "
                    .ToRichOutput()
                    .GetInt(), "Enter num2: "
                    .ToRichOutput()
                    .GetInt()));
            
            if (string.Equals(selection,"R", StringComparison.InvariantCultureIgnoreCase)) 
                Console.WriteLine(GetRounded("Enter num: "
                    .ToRichOutput()
                    .GetDouble()));
            
            if (string.Equals(selection,"B", StringComparison.InvariantCultureIgnoreCase)) 
                Console.WriteLine(GetBitIncrement("Enter num: "
                    .ToRichOutput()
                    .GetInt()));
            
            if (string.Equals(selection,"M", StringComparison.InvariantCultureIgnoreCase))
                Console.WriteLine(GetMax("Enter num1: "
                    .ToRichOutput()
                    .GetInt(), "Enter num2: "
                    .ToRichOutput()
                    .GetInt()));
        }
    }

    private static double GetSquareRoot(int num) => Math.Sqrt(num);
    private static double GetPower(int num, int power) => Math.Pow(num, power);
    private static double GetRounded(double num) => Math.Round(num);
    private static double GetBitIncrement(int num) => Math.BitIncrement(num);
    private static double GetMax(int num1, int num2) => Math.Max(num1, num2);
}