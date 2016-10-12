using System;

/// <summary>
/// Write a program that does the following:Reads an integer number from the console.
/// Stores in a variable if the number can be divided by 7 and 5 without remainder.
/// Prints on the console "true NUMBER" if the number is divisible without remainder by 7 and 5. 
/// Otherwise prints "false NUMBER". In place of NUMBER print the value of the input number.
/// </summary>
class DivideBy7And5
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int value = int.Parse(Console.ReadLine());

        if (value % 5 == 0 && value % 7 == 0)
        {
            Console.WriteLine(true + " " + value);
        }
        else
        {
            Console.WriteLine(false + " " + value);
        }
    }
}

