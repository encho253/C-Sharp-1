using System;

/// <summary>
/// Write a program that, for a given two numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.
/// Use only one loop.Print the result with 5 digits after the decimal point.
/// </summary>
class Calculate
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double sum = 1 + 1 / x;
        ulong fact = 1;

        for (uint i = 2; i <= n; i++)
        {
            fact = fact * i;
            double pow = Math.Pow(x, i);
            sum = sum + (fact / pow);
        }
        Console.WriteLine("{0:F5}", sum);
    }
}