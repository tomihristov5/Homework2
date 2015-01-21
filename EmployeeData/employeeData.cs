// Problem 10. Employee Data
// A marketing company wants to keep record of its employees. Each record would have the following characteristics:
// First name
// Last name
// Age (0...100)
// Gender (m or f)
// Personal ID number (e.g. 8306112507)
// Unique employee number (27560000…27569999)

using System;

class EmployeeData
{
    static void Main(string[] args)
    {
        string firstName = "Petar";
        string familyName = "Petrov";
        byte age = 22;
        string gender = "Male";
        ulong id = 8306112507;
        uint uniqueEmployeNumber = 2856789;
        Console.WriteLine("First name: {0}\nFamily Name: {1}\nAge: {2}\nGender: {3}\nId: {4}\nUnique Number: {5}", firstName, familyName, age, gender, id, uniqueEmployeNumber);
    }
}

