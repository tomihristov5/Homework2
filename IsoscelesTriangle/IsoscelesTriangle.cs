﻿// Problem 8. Isosceles Triangle
// Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

using System;

class IsoscelesTriangle
{
    static void Main(string[] args)
    {
        char copyright = '\u00a9';
        string line = copyright.ToString();
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine(new string(' ', 3) + copyright + new string(' ', 3));
        Console.WriteLine();
        Console.WriteLine(new string(' ', 2) + copyright + new string(' ', 1) + copyright + new string(' ', 2));
        Console.WriteLine();
        Console.WriteLine(new string(' ', 1) + copyright + new string(' ', 3) + copyright + new string(' ', 1));
        Console.WriteLine();
        Console.WriteLine(copyright + new string(' ', 1) + copyright + new string(' ', 1) + copyright + new string(' ', 1) + copyright);
    }
}





