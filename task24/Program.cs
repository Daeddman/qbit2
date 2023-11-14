using System;

class Task24
{
    static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            if (IsOdd(numbers[i]) || (IsPositive(numbers[i]) && IsThreeDigit(numbers[i])))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }

    static bool IsOdd(int num)
    {
        return num % 2 != 0;
    }

    static bool IsPositive(int num)
    {
        return num > 0;
    }

    static bool IsThreeDigit(int num)
    {
        return num >= 100 && num <= 999;
    }
}