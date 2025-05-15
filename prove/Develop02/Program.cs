using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize classes
        Menu mainMenu = new Menu();
        Entry test = new Entry();  // TEST Entry


        // Initialize variables for Main
        int userChoice = 0;

        // Introduction to the program
        Console.WriteLine("Welcome to YourJourn, your personal Journaling Program.\n");


        while (userChoice != 6)
        {
            mainMenu.displayMenu();

            userChoice = int.Parse(Console.ReadLine()); //NOTE: TAKE IN AN INT INPUT

            mainMenu.parseUserChoice(userChoice, test);
        }
        

    }
}