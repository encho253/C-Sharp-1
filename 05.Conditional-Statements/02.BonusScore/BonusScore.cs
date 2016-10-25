using System;

/// <summary>
/// Write a program that applies bonus score to given score in the range [1…9] by the following rules:
/// If the score is between 1 and 3, the program multiplies it by 10.
/// If the score is between 4 and 6, the program multiplies it by 100.
/// If the score is between 7 and 9, the program multiplies it by 1000.
/// If the score is less than 0 or more than 9, the program prints "invalid score".
/// </summary>
class BonusScore
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int score = int.Parse(Console.ReadLine());

        if (score > 0 && score < 10)
        {
            if (score < 4)
            {
                Console.WriteLine(score*10);
            }
            else if (score < 7)
            {
                Console.WriteLine(score*100);
            }
            else
            {
                Console.WriteLine(score*1000);
            }
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}