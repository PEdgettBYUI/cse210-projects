using System;
using System.ComponentModel.DataAnnotations;

class Program
{    static void Main(string[] args)
    {
    string name = "";
    int fav_num = 0;
    int fav_num_squared = 0;

    DisplayWelcome();
    name = PromptUserName();
    fav_num = PromptUserNumber();
    DisplayResult(name, SquareNumber(fav_num));
    }

// All Functions Below For Program Operation
    static void DisplayWelcome()   //void means that the function does not return anything
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite whole number: ");
        string strUserNum = Console.ReadLine();
        int userNum = int.Parse(strUserNum);

        return userNum;
    }

    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }

    static void DisplayResult(string user, int squared)
    {
        Console.WriteLine($"{user}, the square of your number is {squared}.\n");
    }




        // Function Example
        // int AddNumbers(int first, int second)
        // {
        //     int sum = first + second;
        //     return sum;
        // }

    // Function Template
        // returnType FunctionName(DataType parameter 1, datatype parameter2)
        // {
        //     // function_body
        //     //return returnType
        // }
}