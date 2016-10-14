using System;

/// <summary>
/// Write a program that reads the coordinates of a point x and y and using an expression checks
/// if given point (x, y) is inside a circle K({0, 0}, 2) - the center has coordinates (0, 0) 
/// and the circle has radius 2. The program should then print "yes DISTANCE" if the point is 
/// inside the circle or "no DISTANCE" if the point is outside the circle.
/// In place of DISTANCE print the distance from the beginning of the coordinate system 
/// - (0, 0) - to the given point.
/// </summary>
class PointInACircle
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        float x = float.Parse(Console.ReadLine());
        float y = float.Parse(Console.ReadLine());
        float radius = 2;

        if (x >= -1000 && x <= 1000 && y >= -1000 && y <= 1000)
        {
            bool inCircle = (x - 0) * (x - 0) + (y - 0) * (y - 0) <= radius * radius;
            float distance = (float)Math.Sqrt((x - 0) * (x - 0) + (y - 0) * (y - 0));

            if (inCircle == true)
            {
                Console.WriteLine("yes {0:0.00}", distance);
            }
            else
                Console.WriteLine("no {0:0.00}", distance);
        }
    }
}