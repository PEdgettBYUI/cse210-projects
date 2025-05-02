using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int numAdded;

        int sum = 0;
        float average = 0;
        int count = 0;
        int largest = 0;

        Console.WriteLine("Welcome to the Number Listing Program");
        Console.WriteLine("Type in whole numbers to add to a list.\nEnter 0 when done.\n");

        List<int> numbers = new List<int>();

        do
        {
            Console.Write("\nEnter number: ");
            string userInput = Console.ReadLine();
            numAdded = int.Parse(userInput);

            if(numAdded != 0)
            {
                numbers.Add(numAdded);
                count++;
            }
            // Console.WriteLine(numAdded);

            // foreach(int i in numbers)   
            // {
            //     Console.Write(i);
            // }
        }
        while(numAdded != 0);

        // Sum
        foreach(int i in numbers)
        {
            sum += i;
        }

        // Average
        // Console.Write("Number of Numbers in Array: ");
        // Console.WriteLine(numbers.Count);
        average = (float)sum / count;

        // Find Maximum
        foreach(int num in numbers)
        {
            if(num > largest)
            {
                largest = num;
            }
            // Console.WriteLine($"The Largest is Now: {largest}");
        }

        // Generate Results of Sum/Average/Maximum
        Console.WriteLine($"\nThe sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");



// //Example of making a new list of type int
        // List<int> words;     //Initialize the list with the constructor
        // numbers = new list<int>();   // create the list in numbers

        //Typically, lists can be created in one line, (see below)
        //List<string> words = new List<string>();

// // List Example
        // List<string> words = new List<string>();
        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");

        // foreach(string i in words)
        // {
        //     Console.Write(i + " ");
        // }
// // List Example - Using Indexes
        // List<string> words = new List<string>();
        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");

        // for(int i=0; i < words.Count; i++)
        // {
        //     Console.Write(words[i] + " ");
        // }
    }
}