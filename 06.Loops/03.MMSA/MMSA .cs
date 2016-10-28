using System;
using System.Linq;

/// <summary>
/// Write a program that reads from the console a sequence of N integer numbers and returns the minimal, 
/// the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
/// The input starts by the number N(alone in a line) followed by N lines, each holding an integer number.
/// The output is like in the examples below.
/// </summary>
class MMSA
{
    /// <summary>
    /// Mains the specified arguments.
    /// </summary>
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] array = new double[n];

        if (n > 0 && n < 1001) {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("min={0:F2}",array.Min());
            Console.WriteLine("max={0:F2}",array.Max());
            Console.WriteLine("sum={0:F2}",array.Sum());
            Console.WriteLine("avg={0:F2}",array.Average());
        }
    }
}