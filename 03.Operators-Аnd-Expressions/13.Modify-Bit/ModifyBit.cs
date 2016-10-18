using System;

/// <summary>
/// We are given an integer number N (read from the console), a bit value v (read from the console as well) 
/// (v = 0 or 1) and a position P (read from the console). 
/// Write a sequence of operators (a few lines of C# code) that modifies N to hold the value v at 
/// the position P from the binary representation of N while preserving all other bits in N. 
/// Print the resulting number on the console.
/// </summary>
class ModifyBit
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int position = byte.Parse(Console.ReadLine());
        byte bitValue = byte.Parse(Console.ReadLine());
       
        if (position > 0 && position < 65 && bitValue == 0)
        {
            ulong mask = (ulong) ~(1 << position);
            number = mask & number;
            Console.WriteLine(number);
        }
        else if (position > 0 && position < 65 && bitValue == 1)
        {
            ulong mask = (ulong) 1 << position;
            number = mask | number;
            Console.WriteLine(number);
        }
               
    }
}