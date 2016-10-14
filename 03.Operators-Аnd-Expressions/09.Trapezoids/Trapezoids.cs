using System;

/// <summary>
/// Write an expression that calculates trapezoid's area by given sides a and b and height h. 
/// The three values should be read from the console in the order shown below. 
/// All three value will be floating-point numbers.
/// </summary>
class Trapezoids
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float h = float.Parse(Console.ReadLine());

        float area = ((a + b) / 2) * h;
        Console.WriteLine("{0:F7}",area);
    }
}