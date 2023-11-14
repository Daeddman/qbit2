using System;


    namespace task15
    {
        class Task15
        {
            static void Main()
            {
                int N = int.Parse(Console.ReadLine());
                if (N >= -10000 & N <= 10000)
                {
                    if (N % 2 == 0)
                    {
                        int p = N * N;
                        Console.WriteLine(p);
                    }
                    else
                    {
                        int z = N - 1;
                        Console.WriteLine(z);
                    }
                }
            }
        }

    }
