using System;
using System.Linq;

/// <summary>
/// Write a program that compares two char arrays lexicographically (letter by letter).
/// </summary>
class CompareCharArrays
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        char[] first = Console.ReadLine().ToCharArray();
        char[] second = Console.ReadLine().ToCharArray();
        int minLength = Math.Min(first.Length, second.Length);
        bool isTrue = true;
        bool isFalse = true;

        if (isTrue)
        {
            for (int i = 0; i < minLength; i++)
            {         
                if (first[i] < second[i])
                {
                    Console.WriteLine("<");
                    isFalse = false;
                    break;
                }
                else if (first[i] > second[i])
                {
                    Console.WriteLine(">");
                    isFalse = false;
                    break;
                }
            }
        }
        if (isFalse)
        {
            if (first.Length > second.Length)
            {
                Console.WriteLine(">");
            }
            else if (first.Length < second.Length)
            {
                Console.WriteLine("<");
            }
        }
        if (first.Length == second.Length)
        {
            for (int i = 0; i < minLength; i++)
            {
                if (first[i] != second[i])
                {
                    isTrue = false;
                }
            }
            if (isTrue)
            {
                Console.WriteLine("=");
            }
        }
    }
}