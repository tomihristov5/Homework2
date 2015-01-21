// Problem 9. Exchange Variable Values
// Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some 
// programming logic.
// Print the variable values before and after the exchange.

using System;

class VariablesValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Int a = " + a + ", int b = " + b);
        int buffer = a;
        a = b;
        b = buffer;
        Console.WriteLine("After the exchange: a = " + a + ", b = " + b);
    }
}

