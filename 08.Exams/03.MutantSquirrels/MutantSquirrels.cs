using System;

/// <summary>
/// Your task is to count the total number of squirrel tails in the forest and send the results back to your boss, 
/// but since you don't like him, and you're about to quit because of what you saw that night - you will 
/// forge the results using some magic numbers. If the total tails count is an even number - you will 
/// multiply the result by 376439. If the total tails count is an odd number - you will divide the result by 7.
/// </summary>
class MutantSquirrels
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        double trees = double.Parse(Console.ReadLine());
        double branches = double.Parse(Console.ReadLine());
        double squirrels = double.Parse(Console.ReadLine());
        double numberTails = double.Parse(Console.ReadLine());

        if (trees >= 1 && trees <= 100000 &&
            branches >= 3 && branches <= 5000 &&
            squirrels >= 5 && squirrels <= 800 &&
            numberTails >= 1 && numberTails <= 100)
        {
            double result = 0;
            double tails = trees * branches * squirrels * numberTails;
            if (tails % 2 == 0)
            {
                result = tails * 376439;
            }
            else
            {
                result = tails / 7;
            }
            Console.WriteLine("{0:F3}", result);
        }
    }
}

