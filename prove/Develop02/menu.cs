using System;
class Menu
{
    public void displayMenu()
    {
        Console.WriteLine("      Menu\n1.Create New Entry\n2.Load Journal Entry\n3.Display Current Journal\n4.Save Current Journal\n5.Save Entry & Exit\n");
    }

    public void parseUserChoice(int choice, Entry anEntry)
    {
        switch (choice)
        {
            case 1:
                Console.WriteLine("Creating New Entry...\n");
                // Create new Entry
                // Add entry to entries list
                // anEntry.dailyPrompt();  // (TESTING):Creates a new Question Prompt
                break;
            case 2:
                Console.WriteLine("Loading Journal Entry...\n");
                // Get filename of Journal.txt
                // Read from Journal.txt
                break;
            case 3:
                Console.WriteLine("Displaying Journal...\n");
                // Display full Journal/entry
                break;
            case 4:
                Console.WriteLine("Current Entry Saved...\n");
                // Get filename of journal.txt
                // write journal with new entries to .txt file
                break;
            case 5:
                Console.WriteLine("Saving Entry and Exiting...\n");
                // Checks if file has been saved, then does same as case 4 before quitting
                break;
            default:
                // Invalid Input Case 
                Console.WriteLine("Please put in a Valid Entry.\n");
                break;
        }
    }


}