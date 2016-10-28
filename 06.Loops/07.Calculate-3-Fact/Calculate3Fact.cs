using System;
using System.Numerics;

/// <summary>
/// In combinatorics, the number of ways to choose N different members out of a group of N different elements 
/// (also known as the number of combinations) is calculated by the following formula: formula For example, 
/// there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write 
/// a program that calculates N! / (K! * (N - K)!) for given N and K.
/// Try to use only two loops.
/// </summary>
class Calculate3Fact
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
        BigInteger nkFact = 1;
        BigInteger result = 0;

        for (int i = 1; i <= n; i++)
        {
            nFact = nFact * i;
            if (i <= k)
            {
                kFact = kFact * i;
            }
        }
        for (int i = 1; i <= n - k; i++)
        {
            nkFact = nkFact * i;
        }

        result = nFact / (kFact * nkFact);
        Console.WriteLine(result);
    }
}
