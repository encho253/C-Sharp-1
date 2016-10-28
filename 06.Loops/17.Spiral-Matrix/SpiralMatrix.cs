using System;

/// <summary>
/// Write a program that reads from the console a positive integer number N (1 ≤ N ≤ 20) 
/// and prints a matrix holding the numbers from 1 to N*N in the form of square spiral like in the examples below.
/// </summary>
class SpiralMatrix
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] array = new int[n, n];
        int element = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n - i; j++)
            {
                element++;
                array[i, j] = element;
            }           
            for (int k = i; k < n - i; k++)
            {
                array[k, (n - i - 1)] = element;
                element++;
            }
            element--;
            for (int l = (n - i - 1); l > i; l--)
            {
                array[(n - i - 1),l] = element ;
                element++;
            }      
            for (int m = n - i - 1; m > i; m--)
            {
                array[m, i] = element ;
                element++;
            }
            element--;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
}