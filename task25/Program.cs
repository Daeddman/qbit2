using System;

class Program
{
    static void Main()
    {
 
        int year = int.Parse(Console.ReadLine());

        bool isLeapYear = IsLeapYear(year);
        Console.WriteLine(isLeapYear ? "YES" : "NO");

        int nextLeapYear = FindNextLeapYear(year);
        Console.WriteLine(nextLeapYear);
    }

    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    static int FindNextLeapYear(int year)
    {
        int nextYear = year + 1;
        while (!IsLeapYear(nextYear))
        {
            nextYear++;
        }
        return nextYear;
    }
}