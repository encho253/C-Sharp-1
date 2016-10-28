using System;

/// <summary>
/// Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
/// Your program should work well for very big numbers, e.g.N = 100000.
/// </summary>
class Trailing0inNFact
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int addFactor = 0;
        int devide = 0;
        int counter = 1;

        while (true) {
            devide = (int)Math.Pow(5,counter);
            addFactor += n / devide;
            if ((n / devide) < 1)
            {
                break;
            }
            counter++;
        }
        Console.WriteLine(addFactor);
    }
}