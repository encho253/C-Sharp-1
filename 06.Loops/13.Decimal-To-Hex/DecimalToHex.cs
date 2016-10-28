using System;
using System.Collections.Generic;
using System.Numerics;

/// <summary>
/// Using loops write a program that converts an integer number to its hexadecimal representation.
/// The input is entered as long. The output should be a variable of type string.
/// Do not use the built-in .NET functionality.
/// </summary>
class DecimalToHex
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        List<string> list = new List<string>();
        string result = null;
        BigInteger remainder = 0;

        while (n > 0)
        {
            if (n % 16 == 0)
            {
                list.Add("0");
            }
            else
            {
                remainder = n % 16;
                
                switch (remainder.ToString())
                {
                    case "10":
                        list.Add("A");
                        break;
                    case "11":
                        list.Add("B");
                        break;
                    case "12":
                        list.Add("C");
                        break;
                    case "13":
                        list.Add("D");
                        break;
                    case "14":
                        list.Add("E");
                        break;
                    case "15":
                        list.Add("F");
                        break;
                    default:
                        list.Add(remainder.ToString());
                        break;
                }
            }
            n = n / 16;
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