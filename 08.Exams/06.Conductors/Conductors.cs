using System;

/// <summary>
/// Do you know that the new price for a public transport ticket in Sofia is 1.60lv? Because of that,
/// a lot of people try to cheat and reuse an already perforated ticket. So the honorable order of the 
/// Conductors decided that they need binary tickets that will be perforated via software. Little did they
/// know that good programmers don't like to pay 1.60lv and can cheat their new system.
/// A binary ticket N is represented by the bits of a 32-bit integer.Each conductor has a perforating device, 
/// which is represented by the bits of another 32-bit integer P.The device with number P perforates the 
/// ticket N by replacing all bits occurrences of the bits of P in N's bits with 0s, starting from right to left.
/// This means that the rightmost occurrence is replaced first, than the new rightmost and so on.
/// Let N = 469 and P = 5, then N = 111010101 and P = 101 in binary numeral system
/// The device searches for the rightmost occurrence of the bits of P in the bits of N - 111010101
/// The device sets the matching bits to 0 and N becomes 111010000
/// The device then searching again for occurrence of the bits of P in N's bits - 111010000
/// The device sets the matching bits to 0 and N becomes 110000000 - 384
/// There are no more matching bits in N, therefore the device won't perforate N anymore
/// Pezo is not a good programmer, but he is a gratischia, who happens to know about this trick.
/// Pezo wants you to write a program that simulates the process for him.He will give you a perforating device
/// P as a number. Then he will provide you with exactly M tickets which you should perforate as described above.
/// After perforating a ticket completely, print it on the console.
/// </summary>
class Conductors
{
    /// <summary>
    /// Defines the entry point of the application.4
    /// </summary>
    static void Main()
    {
        char zero = '0';
        char one = '1';
        char two = '2';
        char three = '3';
        char four = '4';
        char five = '5';
        char six = '6';
        char seven = '7';
        char eight = '8';
        char nine = '9';

        string ns = (nine + two + five).ToString();
        int n = ((nine - '0') * 10 + two - '0') * 10 + five - '0';
        Console.WriteLine(n == int.Parse(ns));
    }
}

//string reverse = StringHelper.ReverseString(mBin);
//string stringNull = string.Join("", arrayNull);
//string replace = reverse.Replace(perforatedBin, stringNull);
//string finalReverse = StringHelper.ReverseString(replace);
