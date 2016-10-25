using System;

/// <summary>
/// Write a program that finds the biggest of three numbers that are read from the console.
/// </summary>
class BiggestOf3
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a >= -200 && a <= 200 && b >= -200 && b <= 200 && c >= -200 && c <= 200)
        {
            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}