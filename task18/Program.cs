using System;


namespace task18
{
    class Task18
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            if (N >= Math.Pow(-10,9) && N <= Math.Pow(10,9))
            {
                if (N % 2 == 0 && N > 0 )
                {
                    Console.WriteLine("YES");
                    Console.WriteLine(N+2);
                }
                else if (N < 0)
                {
                    int p = 2;
                    Console.WriteLine("NO");
                    Console.WriteLine(p);
                }
                else
                {
                    Console.WriteLine("NO");
                    Console.WriteLine(N+1);
                }
            }
        }
    }

}