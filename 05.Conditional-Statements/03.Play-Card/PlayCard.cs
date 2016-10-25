using System;

/// <summary>
/// Classical play cards use the following signs to designate the card face:
/// 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints 
/// "yes CONTENT_OF_STRING" if it is a valid card sign or "no CONTENT_OF_STRING" otherwise.
/// </summary>
class PlayCard
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string cardName = Console.ReadLine();
        string[] cards = { "2", "3", "4", "5", "6", "7","8", "9", "10", "J", "Q", "K","A" };
        string answer = "no";

        for (int i = 0; i < cards.Length; i++)
        {
            if (cards[i] == cardName)
            {
                answer = "yes";
                break;
            }          
        }
        Console.WriteLine("{0} {1}",answer,cardName);
    }
}