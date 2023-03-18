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

// Add Nuget Package: https://www.nuget.org/packages/Russkyc.AttachedUtilities.ConsoleExtensions
using Russkyc.AttachedUtilities.ConsoleExtensions;

namespace DataTypesApp;

public static class DataTypesProgram
{
    public static void Main()
    {
        var apple = new Apple();
        apple.SetQuantity("Enter the pieces of apple: "
            .ToRichOutput()
            .GetInt());
        apple.SetPrice($"Enter the price of {apple.Quantity} apples: "
            .ToRichOutput()
            .GetDouble());
        apple.GetValue();
    }
}

record Apple()
{
    public double Price { get; private set; }
    public int Quantity { get; private set; }

    public void SetPrice(double price) => Price = price;
    public void SetQuantity(int quantity) => Quantity = quantity;
    public void GetValue() => Console.WriteLine($"The total price of {Quantity} apple(s) is: {Price:0.0}\nThe value of the original price is: {Price:0.0}\nThe value of the converted price is: {Convert.ToInt32(Price)}");
}