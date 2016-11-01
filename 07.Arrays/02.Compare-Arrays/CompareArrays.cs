using System;
using System.Linq;

/// <summary>
/// Write a program that reads two integer arrays of size N from the console and compares them element by element.
/// </summary>
class CompareArrays
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstArr = new int[n];
        int[] secondArr = new int[n];
        bool a = false;

        for (int i = 0; i < firstArr.Length; i++)
        {
            firstArr[i] = int.Parse(Console.ReadLine());          
        }
        for (int i = 0; i < secondArr.Length; i++)
        {
            secondArr[i] = int.Parse(Console.ReadLine());
        }

        a = firstArr.SequenceEqual(secondArr);

        if (a)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}