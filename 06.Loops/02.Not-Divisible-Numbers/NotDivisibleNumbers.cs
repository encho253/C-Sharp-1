using System;

/// <summary>
/// Write a program that reads from the console a positive integer N and prints all the numbers
/// from 1 to N not divisible by 3 or 7, on a single line, separated by a space.
/// </summary>
class NotDivisibleNumbers
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (1 < n && n < 1500)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {

                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}