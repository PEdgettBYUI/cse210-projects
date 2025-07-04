// using System;
// using System.Numerics;
// using System.Runtime.InteropServices;
// using System.Security.Cryptography.X509Certificates;


using System.Dynamic;
using System.Security.Cryptography;



class Entry 
{
    private string e_date;
    private string e_prompt;
    private string e_response;

    public void setEDate()
    {
        DateTime currentDate = DateTime.Now;    // retrieves in format (y/m/d)
        string dateAsString = currentDate.ToString("MMMM dd, yyyy");
        e_date = dateAsString;
    }

    // public void showDate()
    // {
    //     Console.WriteLine(e_date);
    // }

}

class Program
{
    //     // Function Definition Example
    //     // PARAMETERS MUST BE DEFINED WITH A DATA TYPE
    //     static double AddNumbers(double a, double b)   //static: cand call function without an object, double: return datatype
    //     {
    //         return a + b;
    //     }

    //     static void DisplayGreeting()   //void means that the function does not return anything
    //     {
    //         Console.WriteLine("Hello Bob, how are you?");
    //     }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        // Creates a timer that writes a "." every X-miliseconds for endTime seconds
        int sleepTime = 100;
        int time = 9;

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(10);

        // Demo of "indexed string animation"
        string animationString2 = "-+\\|/";
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString2[index++ % animationString2.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
        

        // // Simple "Domino" Loading Animation
            // while (DateTime.Now < endTime)
            // {
            //     Console.Write("|");
            //     Thread.Sleep(sleepTime);  //in miliseconds
            //     Console.Write("\b");
            //     Console.Write("/");
            //     Thread.Sleep(sleepTime);
            //     Console.Write("\b");
            //     Console.Write(" _");
            //     Thread.Sleep(sleepTime);
            //     Console.Write("\b");
            //     Console.Write("\\");
            //     Thread.Sleep(sleepTime);
            //     Console.Write("\b");
            // }


            // Demo of Decrementing Countdown
        int count = time;

        while (DateTime.Now < endTime)
        {
            Console.Write(count--);
            Thread.Sleep(1000);
            Console.Write("\b");
        }

        //Demo of Animation Strings
        string animationString = "(^_^)(-_-)";

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[0..5]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
            Console.Write(animationString[5..]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
        }
        

        


//         int x = 10;
        //         // if(x==9);   //Do not put ; at end of if statements
        //         {
        //             Console.WriteLine("END");
        //         }

        // // For loops
        //         // int x = 10;

        //         // int countDown = 0
        //         // We can set i equal to an external variable if we want to

        //         // for(int i = countDown; i < x; i++)
        //         for(int i = 0; i < x; i++)
        //         {
        //             Console.WriteLine($"Boss is cool: {i}");
        //         }
        //         Console.WriteLine("NEXT SEGMENT\n\n");
        //         // Testing using terminal for commits
        //         // Testing using GitHub Desktop for commits

        //     int z = 0;
        //     int y = z++;

        //     Console.WriteLine(z);
        //     // y = ++x;    // Increments y before
        //     Console.WriteLine(y);
        //     x--;

        // // About Lists
        //     List<int> myNumbers = new List<int>();
        //     myNumbers.Add(10);
        //     myNumbers.Add(99);
        //     myNumbers.Add(-123);

        //     int total = 0;

        //     foreach(int i in myNumbers)
        //     {
        //         Console.WriteLine(i);
        //         total += i;
        //     }

        //     Console.WriteLine(total);

        //     double total_a = AddNumbers(123.4546, 987.1234);
        //     Console.WriteLine(total);
        //     Console.WriteLine(AddNumbers(234, 432));

        //     // (See top for Function Def)
        //     DisplayGreeting();


        // // While & Do-While

        //     // while
        //     bool done = false;
        //     while(!done)
        //     {
        //         done = true;
        //     }

        //     // do-while
        //     do{
        //         Console.WriteLine("");
        //     } 
        //     while(!done);

        // // Class Demo (Circle Class)

        //     Console.WriteLine("Bonjour cevu plait?");

        //     Circle myCircle = new Circle();
        //     Circle myCircle2 = new Circle();    // Not the same as the other myCircle, despite using the same class

        //     myCircle.SetRadius(10);
        //     // myCircle._radius = 10;
        //     Console.WriteLine($"{myCircle.GetRadius()}");
        //     Console.WriteLine($"{myCircle.GetArea()}");


        //     myCircle2.SetRadius(10);
        //     // myCircle._radius = 10;
        //     Console.WriteLine($"{myCircle2.GetRadius()}");
        //     Console.WriteLine($"{myCircle2.GetArea()}");

        //     Cylinder myClyinder = new Cylinder();
        //     myClyinder.SetCircle(myCircle);
        //     myClyinder.SetHeight(10);
        //     Console.WriteLine($"{myClyinder.GetVolume()}");


        //     Entry GORSH = new Entry();
        //     GORSH.setEDate();
        //     GORSH.showDate();

    }
}
