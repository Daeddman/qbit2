using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        if (N >= 100 && N <= 999)
        {
            int firstDigit = N / 100;
            Console.WriteLine($"{firstDigit}");
        }
        else
        {
            int lastDigit = N % 10;
            Console.WriteLine($"{lastDigit}");
        }
    }
}