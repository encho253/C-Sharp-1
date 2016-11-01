using System;

/// <summary>
/// Write a program that allocates array of N integers, initializes each element by its index multiplied by 5 
/// and the prints the obtained array on the console.
/// </summary>
class AllocateArray
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long[] array = new long[n];       
        Console.WriteLine(array[0] = 0);

        for (int i = 1; i < array.Length; i++)
        {
            Console.WriteLine(array[i] = array[i - 1] + 5);
        }
    }
}