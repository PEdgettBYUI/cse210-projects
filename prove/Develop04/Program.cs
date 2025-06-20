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
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;
                    
                default:
                    Console.WriteLine("Please input a number from 1-4.");
                    break;
            }
        }

    }
}