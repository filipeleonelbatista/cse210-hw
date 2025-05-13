using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise1 Project.");

        string firstName;
        string lastName;

        Console.Write("What is your first name? ");
        firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        lastName = Console.ReadLine();
        Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName}.\n");
    }
}