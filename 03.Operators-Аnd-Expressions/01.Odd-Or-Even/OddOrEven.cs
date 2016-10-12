using System;

/// <summary>
/// Write a program that reads an integer from the console, uses an expression to check if 
/// given integer is odd or even, and prints "even NUMBER" or "odd NUMBER", where you should 
/// print the input number's value instead of NUMBER.
/// </summary>
class OddOrEven
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Please, enter a integer number");
        int evenOrOdd = int.Parse(Console.ReadLine());

        if (evenOrOdd % 2 == 0)
        {
            Console.WriteLine("even " + evenOrOdd);
        }
        else
        {
            Console.WriteLine("odd " + evenOrOdd);
        }
    }
}

