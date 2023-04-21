// MIT License
// 
// Copyright (c) 2023 Russell Camo (Russkyc)
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

namespace ArraysApp;

public static class App
{
    public static void Main()
    {
        // A one-dimensional array that contains six (6) names of your classmates. Then, print the names using a foreach loop.
        foreach (
            var name in new[]
                 {
                     "Joshua Meliton",
                     "Vrandon Mayol",
                     "Jude España",
                     "Regilyn Operio",
                     "Justin Hart",
                     "Neil Ivan"
                 })
            Console.WriteLine($"{name}, ");
        
        // A two-dimensional array with two (2) rows and three (3) columns. Then, initialize the array with the first six (6) letters of the alphabet as its elements.
        foreach (
            var letter in new[,]
                 {
                     { 'A', 'B', 'C' },
                     { 'D', 'E', 'F' }
                 })
            Console.WriteLine($"{letter}, ");
        
        // A string with any message. Then, determine if the message contains the string, "hello".
        Console.WriteLine(
            "This string contains the word hello"
            .Contains("hello", StringComparison.InvariantCultureIgnoreCase)
            );
    }
}