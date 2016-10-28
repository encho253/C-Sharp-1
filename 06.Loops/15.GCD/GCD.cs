using System;

/// <summary>
/// Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.
/// Use the Euclidean algorithm(find it in Internet).
/// </summary>
class GCD
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string[] num = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(num[0]);
        int b = Convert.ToInt32(num[1]);

        int remainder = 0;
        
        while (a > 0 && b > 0)
        {
            if (a > b)
            {
                remainder = a % b;
                a = b;
                b = remainder;                
            }
            else
            {
                remainder = b % a;
                b = a;
                a = remainder;
            }
        }
        if (a == 0)
        {          
            Console.WriteLine(b);
        }
        else if (b == 0)
        {
            Console.WriteLine(a);
        }
    }
}