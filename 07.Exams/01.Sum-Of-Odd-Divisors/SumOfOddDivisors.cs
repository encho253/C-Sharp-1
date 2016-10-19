using System;

/// <summary>
/// Odd divisors sum is called the sum of all odd divisors of a given integer.
/// For example: 6 has 4 divisors(1, 2, 3 and 6) but only 1 and 3 of them are odd, 
/// so the sum of all odd divisors of 6 is 4.
/// You are given 2 numbers: A and B.For each number in the interval A, B sum the sum of their odd divisors.
/// </summary>
class SumOfOddDivisors
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
    
        if (1 <= a && a <= 1000 && 1 <= b && b <= 1000)
        {
            int result = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (i % j == 0 )
                    {
                        if (j % 2 > 0)
                        {
                            result = j + result;
                        }                      
                    }
                }             
            }
            Console.WriteLine(result);
        }
    }
}

