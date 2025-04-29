using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        int x = 10;
        // if(x==9);   //Do not put ; at end of if statements
        {
            Console.WriteLine("END");
        }

// For loops
        // int x = 10;

        // int countDown = 0
        // We can set i equal to an external variable if we want to
        
        // for(int i = countDown; i < x; i++)
        for(int i = 0; i < x; i++)
        {
            Console.WriteLine($"Bos is cool: {i}");
        }
        // Testing using terminal for commits
    
    }
}
