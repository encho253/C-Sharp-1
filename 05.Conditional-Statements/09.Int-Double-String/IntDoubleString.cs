using System;

/// <summary>
/// Write a program that, depending on the first line of the input, reads an int, double or string variable.
/// If the variable is int or double, the program increases it by one.
/// If the variable is a string, the program appends* at the end.
/// Print the result at the console. Use switch statement.
/// </summary>
class IntDoubleString
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string type = Console.ReadLine();
        string value = Console.ReadLine();

        switch (type)
        {
            case "integer":
                  int integer = Int32.Parse(value) + 1;
                Console.WriteLine(integer);
                break;
            case "real":
                double real = double.Parse(value) + 1;
                Console.WriteLine("{0:F2}",real);
                break;
            case "text":
                Console.WriteLine(value + "*");
                break;
            default:
                break;
        }
    }
}