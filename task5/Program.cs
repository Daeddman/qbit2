using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Trim().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);
        

        if ((a*a + b*b == c*c) | (b*b + c*c == a*a) | (c*c + a*a == b*b) )
        {
            double p = ((a + b + c) / 2.0);
            double s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            Console.WriteLine(s);
        }
        else
        {
            Console.WriteLine(a+b+c);
        }
    }
}