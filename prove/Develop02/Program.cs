// Patrick T. Edgett
// CSE210 - Prog. W/ Classes
// NOTE:
    // Currently, all journals get saved in bin\Debug\net8.0.
    // Not sure how to fix that atm....
using System;



class Program
{
    static void Main(string[] args)
    {
        // Initialize classes
        Menu mainMenu = new Menu();
        Journal jtest = new Journal();
        Entry test = new Entry();  // TEST Entry


        // Initialize variables for Main
        int userChoice = 0;

        // Introduction to the program
        Console.WriteLine("Welcome to YourJourn, your personal Journaling Program.\n");


        while (userChoice != 5)
        {
            Console.WriteLine("----YourJourn----");    // Trying out having the name of the program display above the menu
            mainMenu.displayMenu();
            Console.Write("Choose: ");

            //Makes sure that the User's Input is valid
            string input = Console.ReadLine();
            if (!int.TryParse(input, out userChoice))
            {
                Console.WriteLine("Please enter a valid number.");
                continue; // Skip to next loop iteration
            }

            mainMenu.parseUserChoice(userChoice, test, jtest);
            if (userChoice == 5)
            {
                Console.WriteLine("[CLOSING program...]\n[Goodbye!]\n");
            }
        }


    }
}