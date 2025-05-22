using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");


        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(1, 3);

        string strFract;
        double doubFract;

        f1.printFraction();
        Console.WriteLine();
        f2.printFraction();
        Console.WriteLine();
        f3.printFraction();
        Console.WriteLine();
        Console.WriteLine();

        strFract = f3.GetFractionString();
        doubFract = f3.GetDecimalValue();
        Console.WriteLine(strFract);
        Console.WriteLine(doubFract);
        
    }
}