using System;
using System.Linq;

/// <summary>
/// Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.
/// </summary>
class BiggestOf5
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        double[] array = new double[5];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine(array.Max());
    }
}