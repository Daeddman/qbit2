using System;

namespace task23
{
    class Task23
    {
        static void Main()
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (Math.Abs(a) <= 10000 && Math.Abs(b) <= 10000 && Math.Abs(c) <= 10000)
            {
                int max = Math.Max((Math.Max(a, b)), c);
                int min = Math.Min((Math.Min(a, b)), c);
                Console.WriteLine(max*max);
                Console.WriteLine(min*min);
            }
        }
    }
}