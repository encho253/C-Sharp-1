using System;

/// <summary>
/// Write a program that reads 3 real numbers from the console and prints their sum.
/// </summary>
class SumOf3Numbers
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a < 1001 && a > -1001 
            && b < 1001 && b > -1001 
            && c < 1001 && c > -1001 )
        {
            Console.WriteLine("{0}",a+b+c);
        }      
    }
}

