using System;

/// <summary>
/// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
/// </summary>
class PrintLongSequence
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        for (int i = 2; i < 1002; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else Console.WriteLine(i * -1);
        }
    }
}

