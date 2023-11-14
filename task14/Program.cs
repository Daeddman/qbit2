using System;

namespace task14
{
    class Task14
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            foreach (int number in numbers)
            {
                bool condition1 = IsFourDigitWithUniqueDigits(number);
                bool condition2 = EndsIn369(number);
                bool condition3 = HasZeroInThreeDigits(number);

                int conditionsMet = Convert.ToInt32(condition1) + Convert.ToInt32(condition2) +
                                    Convert.ToInt32(condition3);

                if (conditionsMet == 1)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }

        static bool IsFourDigitWithUniqueDigits(int number)
        {
            if (number >= 1000 && number <= 9999)
            {
                int digit1 = number % 10;
                int digit2 = (number / 10) % 10;
                int digit3 = (number / 100) % 10;
                int digit4 = (number / 1000) % 10;

                return digit1 != digit2 && digit1 != digit3 && digit1 != digit4 &&
                       digit2 != digit3 && digit2 != digit4 &&
                       digit3 != digit4;
            }

            return false;
        }

        static bool EndsIn369(int number)
        {
            int lastDigit = number % 10;
            return lastDigit == 3 || lastDigit == 6 || lastDigit == 9;
        }

        static bool HasZeroInThreeDigits(int number)
        {
            if (number >= 100 && number <= 999)
            {
                int digit1 = (number / 100) % 10;
                int digit2 = (number / 10) % 10;
                int digit3 = number % 10;

                return digit1 == 0 || digit2 == 0 || digit3 == 0;
            }

            return false;
        }
    }
}