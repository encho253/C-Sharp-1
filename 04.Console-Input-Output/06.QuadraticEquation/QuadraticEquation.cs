using System;

/// <summary>
/// Write a program that reads the coefficients a, b and c of a quadratic equation 
/// ax2 + bx + c = 0 and solves it (prints its real roots).
/// </summary>
class QuadraticEquation
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double discriminant = (b * b) - 4 * a * c;

        if (discriminant > 0)
        {
            double x1 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
            double x2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("{0:F2}\r\n{1:F2}", x1, x2);
        }
        else if (discriminant == 0)
        {
            double x = (-b) / (2 * a);
            Console.WriteLine("{0:F2}",x);
        }
        else
        {
            Console.WriteLine("no real roots");    
        }
    }
}