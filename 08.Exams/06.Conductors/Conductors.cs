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
        long perforated = int.Parse(Console.ReadLine());
        long n = long.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            long m = long.Parse(Console.ReadLine());
            string mBin = Convert.ToString(m, 2);

            for (int j = 0; j < mBin.Length; j++)
            {
                long mask = perforated << j;
                if ((mask & m) == 1)
                {

                }
            }
        }
        //string[] finalArray = new string[n];

        //for (int i = 0; i < n; i++)
        //{
        //    int m = int.Parse(Console.ReadLine());
        //    string mBin = Convert.ToString(m, 2);
        //    string perforatedBin = Convert.ToString(perforated, 2);
                              
        //    string[] arrayNull = new string[perforatedBin.Length];
                    
        //    for (int j = 0; j < arrayNull.Length; j++)
        //    {
        //        arrayNull[j] = "0";
        //    }

        //    string reverse = StringHelper.ReverseString(mBin);                
        //    string stringNull = string.Join("", arrayNull);
        //    string replace = reverse.Replace(perforatedBin,stringNull);
        //    string finalReverse = StringHelper.ReverseString(replace);

        //    replace = finalReverse.Replace(perforatedBin, stringNull);
        //    reverse = StringHelper.ReverseString(replace);
        //    replace = reverse.Replace(perforatedBin, stringNull);
        //    finalReverse = StringHelper.ReverseString(replace);

        //    finalArray[i] = finalReverse;                 
        //}
        //for (int i = 0; i < finalArray.Length; i++)
        //{
        //    Console.WriteLine(Convert.ToInt32(finalArray[i], 2).ToString());
        //}
    }
    //static class StringHelper
    //{
    //    /// <summary>
    //    /// Receives string and returns the string with its letters reversed.
    //    /// </summary>
    //    public static string ReverseString(string s)
    //    {
    //        char[] arr = s.ToCharArray();
    //        Array.Reverse(arr);
    //        return new string(arr);
    //    }
    }
