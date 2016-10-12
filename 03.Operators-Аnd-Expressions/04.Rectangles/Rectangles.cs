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
        float width = float.Parse(Console.ReadLine());
        float height = float.Parse(Console.ReadLine());

        float area = width * height;
        float perimeter = (2 * width) + (2 * height);

        Console.WriteLine("{0 :0.00} {1 :0.00}", area, perimeter);
    }
}

