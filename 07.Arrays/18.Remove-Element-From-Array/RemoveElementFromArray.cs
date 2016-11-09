using System;

/// <summary>
/// Write a program that reads an array of integers and removes from it a
/// minimal number of elements in such a way that the remaining array is sorted
/// in increasing order. Print the minimal number of elements that need to be removed in order 
/// for the array to become sorted.
/// </summary>
class RemoveElementFromArray
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main(string[] args)
    { 
        int n = int.Parse(Console.ReadLine());
        int[] nArray = new int[n];
        for (int i = 0; i <= nArray.Length - 1; i++)
        {
            nArray[i] = int.Parse(Console.ReadLine());
        }

        int[] LIS = new int[n]; 
        for (int i = 0; i <= LIS.Length - 1; i++)
        {
            LIS[i] = 1;
        }
  
        for (int masterIndex = 1; masterIndex < n; masterIndex++)
        {
            for (int subIndex = 0; subIndex < masterIndex; subIndex++)
            {
                if ((nArray[masterIndex] >= nArray[subIndex]) && (LIS[subIndex] >= LIS[masterIndex]))
                {
                    LIS[masterIndex] = LIS[subIndex] + 1;
                }
            }
        }
    
        Array.Sort(LIS);
        int printResult = n - LIS[LIS.Length - 1];
        Console.WriteLine(printResult);
    }
}