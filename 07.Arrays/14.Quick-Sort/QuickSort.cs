using System;

/// <summary>
/// Write a program that sorts an array of integers using the Quick sort algorithm.
/// </summary>
class QuickSort
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arr);

        foreach (int i in arr)
            Console.WriteLine(i);
    }
}