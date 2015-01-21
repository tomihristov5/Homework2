// Problem 2. Float or Double?
// Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
// Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatOrDouble
{
    static void Main(string[] args)
    {
        double var1 = 34.567839023D;
        float var2 = 12.345F;
        double var3 = 8923.1234857D;
        float var4 = 3456.091F;
        Console.WriteLine("{0} , {1} , {2} , {3}", var1, var2, var3, var4);
    }
}

