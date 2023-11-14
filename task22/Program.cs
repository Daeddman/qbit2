using System;

namespace task22
{
    class Task22
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            if (a >= -10000 & a <= 10000 && b >= -10000 && b <= 10000)
            {
                int max = Math.Max(a, b);
                int min = Math.Min(a, b);
                Console.WriteLine(max*max);
                Console.WriteLine(min*min);
            }
        }
    }
}