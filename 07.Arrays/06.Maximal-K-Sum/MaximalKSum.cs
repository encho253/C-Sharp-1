using System;

/// <summary>
/// 
/// </summary>
class MaximalKSum
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] numbersArr = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            numbersArr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbersArr);
        for (int i = numbersArr.Length - 1; i >= (numbersArr.Length - k); i--)
        {
            sum += numbersArr[i];
        }
        Console.WriteLine(sum);
    }
}