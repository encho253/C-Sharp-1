using System;

/// <summary>
/// Write a program that reads an integer number N from the console and prints all the numbers in the interval [1, n],
/// each on a single line.
/// </summary>
class NumbersFrom1toN
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 1 && n < 1000)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i+1);
            }
        }
    }
}

