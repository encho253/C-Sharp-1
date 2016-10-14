using System;

/// <summary>
/// Write a program that reads from the console two integer numbers P and N and 
/// prints on the console the value of P's N-th bit.
/// </summary>
class NthBit
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int p = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        if (n < 55 && p >= 0 && p <= Math.Pow(2,55))
        {
            int mask = 1 << n;
            int andMask = p & mask;
            int bit = andMask >> n;
            Console.WriteLine(bit);
        } 
    }
}

