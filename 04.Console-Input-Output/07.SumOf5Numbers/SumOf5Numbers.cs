using System;

/// <summary>
/// Write a program that reads 5 integer numbers from the console and prints their sum.
/// </summary>
class SumOf5Numbers
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}", a + b + c + d + e);
    }
}