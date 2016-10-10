using System;

class PrintTheASCIITable
{
    static void Main()
    {
        for (int i = 33; i < 127; i++)
        {
            Console.WriteLine((char)i);
        }
    }
}

