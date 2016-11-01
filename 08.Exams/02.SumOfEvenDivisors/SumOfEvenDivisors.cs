using System;

/// <summary>
/// Even divisors sum is called the sum of all even divisors of a given integer.
/// For example: 6 has 4 divisors(1, 2, 3 and 6) but only 2 and 6 of them are even, so the sum of 
/// all even divisors of 6 is 8.
/// You are given 2 numbers: A and B.For each number in the interval A, B sum the sum of their even divisors.
/// </summary>
class SumOfEvenDivisors
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
                    if (i % j == 0)
                    {
                        if (j % 2 == 0)
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


