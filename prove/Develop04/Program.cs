using System;

class Program
{
    static void Main(string[] args)
    {
        Menu mainmenu = new Menu();

        int choice = 0;
        while (choice != 4)
        {
            mainmenu.displayMenu();

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                // Breathing
                case 1:
                    Activity TEST = new Activity("Breathing", "This a is a description of the activity you are viewing. WHEEEEE");
                    TEST.DisplayWelcome();
                    TEST.DisplayEndMessage();
                    break;
                // Reflecting
                case 2:
                    break;
                // Listing
                case 3:
                    break;
                // Quit
                case 4:
                    break;
                // Error Handling
                default:
                    Console.WriteLine("Please input a number from 1-4.");
                    break;
            }
        }

    }
}