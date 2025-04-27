using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Pass-Checker.");
        Console.WriteLine("Here we'll take your number grade and tell you what letter grade you recieved, and if you passed. \n");

        // Determining the letter grade
        Console.WriteLine("What was your grade? %");
        string userInput = Console.ReadLine();
        int gradePercent = int.Parse(userInput);
        string letterGrade = "";

        if(gradePercent >= 90)
        {
            // Console.WriteLine("You got a A!");
            letterGrade = "A";

            // if(gradePercent)
            // {
            //     Console.WriteLine('You Got an "B+" !');
            // }
        }
        else if (gradePercent >= 80)
        {
            // Console.WriteLine("You got a B!");
            letterGrade = "B";
        }
        else if (gradePercent >= 70)
        {
            // Console.WriteLine("You got a C.");
            letterGrade = "C";
        }   
        else if (gradePercent >= 70)
        {
            // Console.WriteLine("You got a D...");
            letterGrade = "D";
        }
        else
        {
            // Console.WriteLine("You got an F.");
            letterGrade = "F";
        }

        // Determine if the user passed

        Console.WriteLine($"Your Grade was an {letterGrade}.");

        if(gradePercent >= 70)
        {
            Console.WriteLine("You Passed! Good Job!");
        }
        else
        {
            Console.WriteLine("You didn't Pass. Study more next time.\n");
        }



    }
}