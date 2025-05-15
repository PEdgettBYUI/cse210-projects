using System;
class Menu
{
    public void displayMenu()
    {
        Console.WriteLine("      Menu\n1.Create New Entry\n2.Load Journal Entry\n3.Display Current Journal\n4.Save Current Journal\n5.Save Entry & Exit\n");
    }

    public void parseUserChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                Console.WriteLine("Creating New Entry...");
                break;
            case 2:
                Console.WriteLine("Loading Journal Entry...");
                break;            
            case 3:
                Console.WriteLine("Displaying Journal...");
                break;            
            case 4:
                Console.WriteLine("Current Entry Saved...");
                break;
            case 5:
                Console.WriteLine("Saving Entry and Exiting...");
                break;
        }
    }


}