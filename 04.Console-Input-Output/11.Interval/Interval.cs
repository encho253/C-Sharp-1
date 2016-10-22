using System;

/// <summary>
/// Write a program that reads two positive integer numbers N and M and prints how many 
/// numbers exist between them such that the reminder of the division by 5 is 0.
/// </summary>
class Interval
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int counter = 0;

        if (n >= 0 && n <= m && m <= 2000)
        {
            for (int i = n + 1; i < m; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}

