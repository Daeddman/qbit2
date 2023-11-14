using System;

class Program
{
    static void Main()
    {
        double N = double.Parse(Console.ReadLine());

        if (N % 1 == 0)
        {
            int n = (int)Math.Abs(N);
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            Console.WriteLine($"{sum}");
        }
        else
        {
            double absN = Math.Abs(N);
            double squareRoot = Math.Sqrt(absN);
            Console.WriteLine($"{squareRoot}");
        }
    }
}