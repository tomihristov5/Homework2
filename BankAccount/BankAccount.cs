// Problem 11. Bank Account Data
// A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name,
// IBAN, 3 credit card numbers associated with the account.
// Declare the variables needed to keep the information for a single bank account using the appropriate data types 
// and descriptive names

using System;

class BankAccount
{
    static void Main(string[] args)
    {
        string firstName = "Petar";
        string middleName = "Petrov";
        string lastName = "Petrov";
        decimal moneyAmount = 6666;
        string bankName = "National Bank";
        string IBAN = "1234567890";
        string BIC = "1234567890";
        string card1 = "221234009990";
        string card2 = "555234567890";
        string card3 = "999234567890";
        Console.WriteLine("{0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Money amound: {0:c} Bank: {1}", moneyAmount, bankName);
        Console.WriteLine("IBAN: {0} BIC: {1}", IBAN, BIC);
        Console.WriteLine("Card 1: {0}\nCard 2: {1}\nCard 3: {2}", card1, card2, card3);
    }
}

