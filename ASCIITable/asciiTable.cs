//Problem 14.* Print the ASCII Table

using System;

class AsciiTable
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 255; i++)
        {
            Console.Write(((char)i));
            Console.Write(" ");
        }
    }
}

