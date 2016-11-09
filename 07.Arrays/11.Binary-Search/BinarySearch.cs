using System;

/// <summary>
/// Write a program that finds the index of given element X in a sorted array of N integers by using 
/// the Binary search algorithm.
/// </summary>
class BinarySearch
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int min = 0; 
        int max = array.Length - 1;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);

        int x = int.Parse(Console.ReadLine());

        while (min <= max)
        {
            int mid = (min + max) / 2;
            if (array[mid] > x)
            {
                max = mid - 1;            
            }
            else if (array[mid] < x)
            {
               min = mid + 1;
            }
            else
            {
                Console.WriteLine(++mid);
                break;      
            }           
        }
    }
}