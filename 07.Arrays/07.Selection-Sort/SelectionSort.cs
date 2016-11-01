using System;

/// <summary>
/// Sorting an array means to arrange its elements in increasing order. 
/// Write a program to sort an array. Use the Selection sort algorithm: 
/// Find the smallest element, move it at the first position, find the smallest from the rest, 
/// move it at the second position, etc.
/// </summary>
class SelectionSort
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int index = 0;
        int value = 0;
        bool inside = false;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                if (array[index] > array[j])
                {
                    index = j;
                    value = array[index];
                    inside = true;
                }          
            }
            if (inside)
            {
                array[index] = array[i];
                array[i] = value;
                index = i;
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}