// using System;
// using System.Numerics;
// using System.Runtime.InteropServices;
// using System.Security.Cryptography.X509Certificates;


// Classes cannot be defined in Main; must be external to the program
// Private means the variable cannot be accessed outside of the class
// Public means that it can be accessed from outside of the class
// i.e. you can use Circle.SetRadius() & Circle.GetRadius(), but you can't access "private double _radius;" directly
using System.Dynamic;

class Circle
{
    private double _radius; // attribute

    public void SetRadius(double radius)
    {
        int bob = 9;    // This is a local variable, not an attribute of the class
        if(radius <0)
        {
            Console.WriteLine("Error");
            return;
        }
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
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
//         Console.WriteLine("Hello Sandbox World!");

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
    
// // NEW THING HERE

        Console.WriteLine("Bonjour cevu plait?");
        
        Circle myCircle = new Circle();
        Circle myCircle2 = new Circle();    // Not the same as the other myCircle, despite using the same class

        myCircle.SetRadius(10);
        // myCircle._radius = 10;
        Console.WriteLine($"{myCircle.GetRadius()}");
        Console.WriteLine($"{myCircle.GetArea()}");



    }
}
