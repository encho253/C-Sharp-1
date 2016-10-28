using System;

/// <summary>
/// You are given N integers (given in a single line, separated by a space).
/// Write a program that checks whether the product of the odd elements 
/// is equal to the product of the even elements.
/// Elements are counted from 1 to N, so the first element is odd, the second is even, etc.
/// </summary>
class OddAndEvenProduct
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] num = Console.ReadLine().Split(' ');
        long sumOdd = 1;
        long sumEven = 1;

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                sumOdd *= Convert.ToInt32(num[i - 1]);
            }
            else
            {
                sumEven *= Convert.ToInt32(num[i - 1]);
            }
        }
        if (sumEven == sumOdd)
        {
            Console.WriteLine("yes {0}",sumEven);
        }
        else
        {
            Console.WriteLine("no {0} {1}",sumEven,sumOdd);
        }
    }
}