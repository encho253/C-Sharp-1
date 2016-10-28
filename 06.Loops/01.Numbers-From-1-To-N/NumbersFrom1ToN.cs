using System;

/// <summary>
/// Write a program that enters from the console a positive integer n and prints all the numbers
/// from 1 to N inclusive, on a single line, separated by a whitespace.
/// </summary>
class NumbersFrom1ToN
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }
    }
}