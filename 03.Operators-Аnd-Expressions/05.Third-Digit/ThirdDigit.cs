using System;

/// <summary>
/// Write a program that reads an integer N from the console and prints true if the 
/// third digit of N is 7, or "false THIRD_DIGIT", where you should print the third digits of N.
/// The counting is done from right to left, meaning 123456's third digit is 4.
/// </summary>
class ThirdDigit
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        n = (n / 100) % 10;
        if (n == 7)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false + " {0}",n);
        }
    }
}

