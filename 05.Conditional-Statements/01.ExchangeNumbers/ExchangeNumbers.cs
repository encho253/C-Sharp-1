using System;

/// <summary>
/// Write a program that reads two double values from the console A and B, 
/// stores them in variables and exchanges their values if the first one is greater than the second one. 
/// Use an if-statement. As a result print the values of the variables A and B, separated by a space.
/// </summary>
class ExchangeNumbers
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        if (a >= -100 && a <= 100 && b >= -100 && b <= 100)
        {
            if (a > b)
            {
                Console.WriteLine("{0} {1}",b,a);
            }
            else
            {
                Console.WriteLine("{0} {1}",a,b);
            }
        }
    }
}