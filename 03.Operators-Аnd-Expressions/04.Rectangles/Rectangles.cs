using System;

/// <summary>
/// Write an expression that calculates rectangle’s area and perimeter by given width and height. 
/// The width and height should be read from the console.
/// </summary>
class Rectangles
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = width * height;
        double perimeter = 2 * (width + height);

        Console.WriteLine("{0:F2} {1:F2}", area, perimeter);
    }
}