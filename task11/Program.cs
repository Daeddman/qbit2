using System;


namespace task15
{
    class Task15
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            double a = double.Parse(input[0]);
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);
            if (a > 0 & b > 0 & c > 0)
            {
                
                if (a == b && a == c && b == c)
                {
                    Console.WriteLine("Equilateral triangle.");
                }
                else if (a == b | b == c | a == c)
                {
                    Console.WriteLine("Isosceles triangle.");
                }
                else if ((a + b > c & a + c > b & b + c > a) & ( a != b & a != c & b != c ))
                {
                    Console.WriteLine("Sided triangle.");
                }
                else if (a + b <= c | a + c <= b | b + c <= a)
                {
                    Console.WriteLine("Triangle does not exist.");
                }
                
            }
            else
            {
                Console.WriteLine("Incorrect data.");
            }
        }
    }

}