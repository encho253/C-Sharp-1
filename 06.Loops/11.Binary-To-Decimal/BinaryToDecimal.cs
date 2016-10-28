using System;
using System.Numerics;
using System.Text.RegularExpressions;

/// <summary>
/// Using loops write a program that converts a binary integer number to its decimal form.
/// The input is entered as string. The output should be a variable of type long.
/// Do not use the built-in .NET functionality.
/// </summary>
class BinaryToDecimal
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string bin = Console.ReadLine();
        string[] binArray = Regex.Split(bin, "");
        BigInteger counter = 1;
        BigInteger sum = 0;
        BigInteger finalSum = 0;

        for (int i = binArray.Length - 2; i > 0; i--)
        {          
            sum = counter * Int32.Parse(binArray[i]);
            finalSum += sum;
            counter *= 2;
        }
        Console.WriteLine(finalSum);
    }
}