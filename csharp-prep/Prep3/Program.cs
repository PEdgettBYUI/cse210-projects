// Patrick T. Edgett
using System;

class Program
{

    static void Main(string[] args)
    {
        //Initialize variables
        int numGuess;
        int magicNum;

        string replay = "play";

        //Program Introduction
        Console.WriteLine("\nWelcome to Magic Number Guessing Game!\nThe Goal is to guess a random number from 1-100.\n");

        //Create the Game Loop for replaying 
        do{
            //User-defined Magic Number
            // Console.Write("What is the magic number? ");
            // string userInput = Console.ReadLine();
            // magicNum = int.Parse(userInput);

            //Initialize random number generator
            Random randomGenerator = new Random();
            magicNum = randomGenerator.Next(1,101); //.Next will stop before the end number; i.e. (1,101) only includes 1-100

            Console.WriteLine("\nNow The Game Begins.");

            do
            {
                //Console.Write(magicNum);
                //User Guess
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                numGuess = int.Parse(guess);

                //Determine if the guess is equal to the Magic Number
                if(numGuess > magicNum)
                {
                    Console.WriteLine(" Lower");
                }
                else if(numGuess < magicNum)
                {
                    Console.WriteLine(" Higher");
                }
                else
                {
                    Console.WriteLine("\n You've Guessed It!");
                }
            }
            while(numGuess != magicNum);

            // Prompt to Replay
            Console.Write("Do you want to try again? (y/n) ");
            replay = Console.ReadLine();
        }
        while(replay != "n");

        // End Program Message
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Thanks for Playing!\nPlay Again Sometime!\nBye!\n");
       
    }
}