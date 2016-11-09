using System;

/// <summary>
/// Write a program that finds the most frequent number in an array of N elements.
/// </summary>
class FrequentNumber
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int frequent = 0;
        int mostFrequent = 0;
        int numberFrequent = 0;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    frequent++;
                }
                if (frequent > mostFrequent)
                {
                    mostFrequent = frequent;
                    numberFrequent = array[i];
                }
            }
            frequent = 0;
        }
        Console.WriteLine("{0} ({1} times)",numberFrequent,mostFrequent);
    }
}