using System;

/// <summary>
/// Write a program that creates an array containing all letters from the alphabet (a-z). 
/// Read a word from the console and print the index of each of its letters in the array.
/// </summary>
class IndexOfLetters
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string word = Console.ReadLine();
        char[] wordArray = word.ToCharArray();

        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        char[] alphas = alphabet.ToCharArray();

        for (int i = 0; i < wordArray.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (wordArray[i] == alphas[j])
                {
                    Console.WriteLine(j);
                    break;
                }
            }
        }
    }
}