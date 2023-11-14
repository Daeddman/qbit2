using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace task12
{
    class Task12
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for (int i=0; i<5; i++ )
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                bool condition1 = IsFourDigit(numbers[i]);
                bool condition2 = IsNotEvenPositive(numbers[i]);
                bool condition3 = IsMultipleThreeAndFive(numbers[i]);
                    
                if (condition1 & condition2 & condition3)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
        }

        static bool IsFourDigit (int num)
        {
            return num.ToString().Length == 4;
        }

        static bool IsNotEvenPositive(int num)
        {
            return num % 2 != 0 && num > 0;
        }

        static bool IsMultipleThreeAndFive(int num)
        {
            return num % 3 != 0 && num % 5 != 0;
        }
    }
}