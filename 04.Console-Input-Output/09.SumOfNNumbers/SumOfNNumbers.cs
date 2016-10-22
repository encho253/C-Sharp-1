using System;

/// <summary>
/// Write a program that enters a number N and after that enters more N numbers and calculates and prints their sum.
/// </summary>
class SumOfNNumbers
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        double n = int.Parse(Console.ReadLine());
        double sum = 0;
        if (n >= 1 && n <= 200) {
            for (int i = 0; i < n; i++)
            {
                double number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine(sum);
        }
    }
}

