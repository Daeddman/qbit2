using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            int number = int.Parse(Console.ReadLine());

            int hundreds = number / 100;
            int tens = (number / 10) % 10;
            int units = number % 10;

            if (hundreds != tens && tens != units && units != hundreds)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}