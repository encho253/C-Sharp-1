using System;
using System.Globalization;
using System.Text.RegularExpressions;

/// <summary>
/// Write a program that reads your birthday(in the format MM.DD.YYYY) from the console and prints
/// on the console how old you are you now and how old will you be after 10 years.
/// </summary>
class Age
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        string date = Console.ReadLine();
        string format = "mm.dd.yyyy";
        int afterTenYears = 0;
        int ageNow = 0;

        DateTime birhtdate = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);

        ageNow = DateTime.Today.Year - birhtdate.Year;
        afterTenYears = DateTime.Today.Year - birhtdate.Year + 10;

        if (birhtdate.Day > DateTime.Today.Day && birhtdate.Month <= DateTime.Today.Month)
        {
            Console.WriteLine(ageNow - 1);
            Console.WriteLine(afterTenYears - 1);
        }
        else
        {
            Console.WriteLine(ageNow);          
            Console.WriteLine(afterTenYears);
        }
    }
}


