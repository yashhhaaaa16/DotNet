﻿namespace Question22;

internal class Program
{
    static void Main(string[] args)
    {
        int day, month, year;

        GetDate(out day, out month, out year);

        Console.WriteLine($"\nDate - {day}/{month}/{year}");

    }

    static void GetDate(out int day, out int month, out int year)
    {
        Console.Write("Enter day: ");
        day = int.Parse(Console.ReadLine());

        Console.Write("Enter month: ");
        month = int.Parse(Console.ReadLine());

        Console.Write("Enter year: ");
        year = int.Parse(Console.ReadLine());
    }
}
