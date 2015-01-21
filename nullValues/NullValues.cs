// Problem 12. Null Values Arithmetic
// Create a program that assigns null values to an integer and to a double variable.
// Try to print these variables at the console.
// Try to add some number or the null literal to these variables and print the result.

using System;

class NullValues
{
    static void Main(string[] args)
    {
        int? first = null;
        double? second = null;
        Console.WriteLine("First: {0}, Second: {1}", first, second);
        Console.WriteLine("Adding value one: ");
        first = int.Parse(Console.ReadLine());
        Console.WriteLine("Adding value two: ");
        second = int.Parse(Console.ReadLine());
        Console.WriteLine("First: {0}, Second: {1}", first, second);
    }
}

