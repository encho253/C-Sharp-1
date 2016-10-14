using System;

/// <summary>
/// Using bitwise operators, write a program that uses an expression to find the value of the bit at 
/// index 3 of an unsigned integer read from the console.
/// The bits are counted from right to left, starting from bit 0.
/// The result of the expression should be either 1 or 0. Print it on the console.
/// </summary>
class Bit3rd
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        int andMask = n & mask;
        int bit3 = andMask >> 3;
        Console.WriteLine(bit3);
    }
}