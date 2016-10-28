using System;
using System.Numerics;

/// <summary>
/// Write a program that calculates N! / K! for given N and K.
/// Use only one loop.
/// </summary>
class CalculateAgain
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        BigInteger kFact = 1;
 
        if (1 < k && k < n && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                nFact = nFact * i;
                if (i <= k)
                {
                    kFact = kFact * i;
                }
            }           
            Console.WriteLine(nFact / kFact);
        }
    }
}