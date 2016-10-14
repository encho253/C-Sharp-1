using System;

/// <summary>
/// Write a program that reads a pair of coordinates x and y and uses an expression to checks 
/// for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle 
/// R(top=1, left=-1, width=6, height=2).
/// </summary>
class PointCircleRectangle
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        float x = float.Parse(Console.ReadLine());
        float y = float.Parse(Console.ReadLine());

        if (x >= -1000 && x <= 1000 && y >= -1000 && y <= 1000)
        {
            bool inCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5;
            bool insideRectangle = (x >= -1) && (x <= (-1 + 6)) && (y <= 1) && (y >= (1 - 6));

            if (inCircle == true && insideRectangle == true)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            else if (inCircle == false && insideRectangle == false)
            {
                Console.WriteLine("outside circle outside rectangle");
            }
            else if (inCircle == true && insideRectangle == false)
            {
                Console.WriteLine("inside circle outside rectangle");
            }
            else
            {
                Console.WriteLine("outside circle inside rectangle");
            }
        }
    }
}