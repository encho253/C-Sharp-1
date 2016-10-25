using System;

/// <summary>
/// 
/// </summary>
class Sort3Numbers
{
    /// <summary>
    /// Defines the entry point of the application.
    /// Use nested if statements.
    /// Don’t use arrays and the built-in sorting functionality.
    /// </summary>
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a >= -1000 && a <= 1000 && b >= -1000 && b <= 1000 && c >= -1000 && c <= 1000)
        {
            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
            }
            else
            {
                if (b < a)
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                }
            }
        }

    }
}