using System;

/// <summary>
/// Write a program that reads from the console the radius r of a circle and prints its perimeter and area,
/// rounded and formatted with 2 digits after the decimal point.
/// </summary>
class Circle
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        if (r >= 0)
        {       
            double area = r * r * Math.PI;
            double perimeter = 2 * Math.PI * r;

            Console.WriteLine("{0:F2} {1:F2}",perimeter,area);
        }
    }
}