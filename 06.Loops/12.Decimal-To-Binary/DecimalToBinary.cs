using System;
using System.Collections.Generic;

/// <summary>
/// Using loops write a program that converts an integer number to its binary representation.
/// The input is entered as long. The output should be a variable of type string.
/// Do not use the built-in .NET functionality.
/// </summary>
class DecimalToBinary
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        long n = int.Parse(Console.ReadLine());
        List<string> list = new List<string>();
        string result = null;

        while (n > 0)
        {
            if (n % 2 == 0)
            {
                list.Add("0");
            }
            else
            {
                list.Add("1");
            }
            n = n / 2;
        }
        result = string.Join("", list.ToArray());
        Console.WriteLine(StringHelper.ReverseString(result));
    }
    static class StringHelper
    {
        /// <summary>
        /// Receives string and returns the string with its letters reversed.
        /// </summary>
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}