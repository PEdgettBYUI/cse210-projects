using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        // This is a test.
        // This is a second change.
        Console.Write("What is your first name? "); //Write - Cursor Same Line; WriteLine - Cursor Next Line
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

        int x = 10;
        // if(x==9);   //Do not put ; at end of if statements
        {
            Console.WriteLine
        }

    }
}