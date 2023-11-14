using System;

namespace task16
{
    class Task16
    {
        static void Main(string[] args)
        {
            string[] inputs = new string[5];

            for (int i = 0; i < 5; i++)
            {
                string input = Console.ReadLine();

                if (input.Length != 2 || !char.IsDigit(input[0]) || !char.IsDigit(input[1]))
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите двузначное число.");
                    i--; 
                    continue;
                }

                inputs[i] = input;
            }

            for (int i = 0; i < 5; i++)
            {
                if (IsDigitsDifferent(inputs[i]))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }

        static bool IsDigitsDifferent(string input)
        {
            return input[0] != input[1];
        }
    }
}