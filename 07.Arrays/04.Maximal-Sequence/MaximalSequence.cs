using System;

/// <summary>
/// 
/// </summary>
class MaximalSequence
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] numbersArr = new double[n];
        int sequence = 1;
        int bestSequence = 0;

        for (int i = 0; i < n; i++)
        {
            numbersArr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i < numbersArr.Length; i++)
        {
            if (numbersArr[i] == numbersArr[i - 1])
            {
                sequence++;
                if (sequence > bestSequence)
                {
                    bestSequence = sequence;
                }
            }
            else
            {
                sequence = 1;
            }          
        }
        Console.WriteLine(bestSequence);
    }
}