using System;

/// <summary>
/// Bojinov is the symbol of Bulgarian chalgaFootballCulture. He likes malki koteta a lot. 
/// Your task is to draw on the console one malko kote. The size of this kote varies and you will
/// receive that number on the input. Please please please help Bojinov to have his malko kote and 
/// never return back to the national football team.
/// </summary>
class MalkoKote
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char cat = char.Parse(Console.ReadLine());

        int size1 = (size / 2) / 2 + 1;
        int size2 = size1 - 1;
        if ((size / 2) % 2 == 0)
        {
            size2 = size1 - 2;
        }
 
        //ears//////////////
        Console.Write(" ");
        for (int e = 0; e < size1; e++)
        {
            if (e == 0 || e == size1 - 1)
            {
                Console.Write(cat);
            }
            else
            {
                Console.Write(" ");
            }
        }
        ////////////////

        Console.WriteLine();

        //head
        for (int h = 0; h < size1 - 2; h++)
        {
            Console.Write(" ");
            for (int h1 = 0; h1 < size1; h1++)
            {
                Console.Write(cat);
            }
            Console.WriteLine();
        }
        /////////////
        //neck
        for (int neck = 0; neck < size1 - 2; neck++)
        {
            Console.Write(" ");
            Console.Write(" ");
            for (int neck1 = 0; neck1 < size1 - 2; neck1++)
            {
                Console.Write(cat);
            }
            Console.Write(" ");
            Console.WriteLine();
        }
        /////////////////////
        //body (first half)

        for (int body = 0; body < size1 - 1; body++)
        {
            Console.Write(" ");
            if (body < size1 - 2)
            {
                for (int body1 = 0; body1 < size1; body1++)
                {
                    Console.Write(cat);
                }
            }
            else
            {
                for (int body1 = 0; body1 < size1; body1++)
                {
                    Console.Write(cat);
                }
                Console.Write("   ");
                for (int tail = 0; tail < size2; tail++)
                {
                    Console.Write(cat);
                }
            }
            Console.WriteLine();
        }
        ////////////////////
        //body (second half)

        for (int i = 0; i < size1; i++)
        {
            for (int j = 0; j < size1 + 2; j++)
            {
                Console.Write(cat);
            }
            Console.Write("  " + cat);
            Console.WriteLine();
        }       

        for (int i = 0; i < size1 + 2; i++)
        {
            Console.Write(cat);
        }
        Console.Write(" " + cat + cat);
        Console.WriteLine();
        Console.Write(" ");

        for (int i = 0; i < size1 + 3; i++)
        {
            Console.Write(cat);
        }

        Console.WriteLine();
        //////////////////////
    }
}

