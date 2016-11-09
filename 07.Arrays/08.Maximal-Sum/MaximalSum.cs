using System;

/// <summary>
/// Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
/// Can you do it with only one loop(with single scan through the elements of the array)?
/// </summary>
class MaximalSum
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int sum = 0;
        int bestSum = 0;
        int index = 0;
        int lastIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        while (lastIndex < array.Length)
        {
            sum += array[index];
            index++;
            if (sum > bestSum)
            {
                bestSum = sum;
            }
            if (index > array.Length - 1)
            {
                lastIndex++;
                index = lastIndex;
                sum = 0;
            }          
        }
        Console.WriteLine(bestSum);        
    }
}