using System;

/// <summary>
/// Write a program that reads an integer N (which will always be less than 100 or equal) and uses an 
/// expression to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).
/// Note: You should check if the number is positive
/// </summary>
class PrimeCheck
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int digit = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (digit <= 100)
        {
            for (int i = 2; i <= Math.Sqrt(digit); i++)
            {              
                if (digit % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (digit == 1 || digit < 1)
            {
                isPrime = false;
            }
            Console.WriteLine(isPrime);
        }
    }
}