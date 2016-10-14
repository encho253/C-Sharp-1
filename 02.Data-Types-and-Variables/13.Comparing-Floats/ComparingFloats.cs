using System;

/// <summary>
/// Write a program that safely compares two floating-point numbers (double) with precision eps = 0.000001.
/// </summary>
class ComparingFloats
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());

        double eps = 0.000001;
        double assume = Math.Abs(firstNumber - secondNumber);

        if (eps > assume)
        {
            Console.WriteLine("true");
        }
        else if(eps <= assume)
        {
            Console.WriteLine("false");
        }
    }
}