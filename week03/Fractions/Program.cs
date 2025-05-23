using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Account savings = new Account();
        savings.Deposit(100);
        savings.Deposit(50);
        Console.WriteLine("Balance: " + savings.GetBalance());
    }
}