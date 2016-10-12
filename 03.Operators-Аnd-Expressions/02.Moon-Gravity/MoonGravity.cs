using System;

/// <summary>
/// The gravitational field of the Moon is approximately 17% of that on the Earth.
/// Write a program that calculates the weight of a man on the moon by a given weight
/// W(as a floating-point number) on the Earth.
/// The weight W should be read from the console.
/// </summary>
class MoonGravity
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        float weightEarth = float.Parse(Console.ReadLine());
        float weightMoon = weightEarth * 0.17f;
        Console.WriteLine("{0:0.000}",weightMoon);
    }
}

