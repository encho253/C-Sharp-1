using System;

/// <summary>
/// Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
/// Use a sequence of if operators.
/// </summary>
class MultiplicationSign
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a != 0 && b != 0 & c != 0)
        {         
            if (a < 0 && b > 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else if (a > 0 && b < 0 && c > 0)
            {
                Console.WriteLine("-");
            }
            else if (a > 0 && b > 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else if (a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}