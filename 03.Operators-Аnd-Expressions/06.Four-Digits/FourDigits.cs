using System;

/// <summary>
/// Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
/// 1.Calculates the sum of the digits(in our example 2 + 0 + 1 + 1 = 4) and prints it on the console.
/// 2.Prints on the console the number in reversed order: dcba (in our example 1102) and prints the reversed number.
/// 3.Puts the last digit in the first position: dabc(in our example 1201) and prints the result.
/// 4.Exchanges the second and the third digits: acbd (in our example 2101) and prints the result.
/// </summary>
class FourDigits
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int digit = int.Parse(Console.ReadLine());
        int a = ((digit / 1000) % 10);
        int b = ((digit / 100) % 10);
        int c = ((digit / 10) % 10);
        int d = digit % 10;

        int sumDigit = a + b + c + d;
        Console.WriteLine(sumDigit);
        Console.WriteLine("{0}{1}{2}{3}",d,c,b,a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
}