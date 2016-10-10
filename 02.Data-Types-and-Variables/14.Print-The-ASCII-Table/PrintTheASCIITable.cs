using System;

/// <summary>
/// 
/// </summary>
class PrintTheASCIITable
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        for (int i = 33; i < 127; i++)
        {
            Console.WriteLine((char)i);
        }
    }
}

