using System;

namespace task2
{
    class Task2
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                bool c1 = IsNegative(numbers[i]);
                bool c2 = TheLastDigit(numbers[i]);
                bool c3 = NotAMultipleThreeAndFive(numbers[i]);
                
                int trueConditionsCount = 0;

                if (c1)
                {
                    trueConditionsCount++;
                }
                if (c2)
                {
                    trueConditionsCount++;
                }
                if (c3)
                {
                    trueConditionsCount++;
                }

                if (trueConditionsCount == 1 || trueConditionsCount == 0 || trueConditionsCount == 3)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
            
            

        }
        static bool IsNegative(int num)
        {
            return num < 0;
        }

        static bool TheLastDigit(int num)
        {
            int absNum = Math.Abs(num);
    
            if (absNum >= 100 && absNum % 10 != 0 && (absNum / 10) % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static bool NotAMultipleThreeAndFive(int num)
        {
            return num % 3 != 0 && num % 5 != 0;
        }

    }
    
}