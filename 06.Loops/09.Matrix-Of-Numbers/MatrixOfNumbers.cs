using System;

/// <summary>
/// Write a program that reads from the console a positive integer number N and 
/// prints a matrix like in the examples below. Use two nested loops.
/// Challenge: achieve the same effect without nested loops
/// </summary>
class MatrixOfNumbers
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < n + i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}