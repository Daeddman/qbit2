using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        if (N >= -10000 && N <= 10000)
        {
            if (N > 0)
            {
                int square = N * N;
                Console.WriteLine(square);
            }
            else if (N < 0)
            {
                int absoluteValue = Math.Abs(N);
                Console.WriteLine(absoluteValue);
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}

