using System;

class Program
{
    static void Main()
    {
        double[][] coordinates = new double[5][];
        for (int i = 0; i < 5; i++)
        {
            string[] input = Console.ReadLine().Trim().Split();
            coordinates[i] = new double[]
            {
                double.Parse(input[0]),
                double.Parse(input[1])
            };
        }

        double A = double.Parse(Console.ReadLine());
        
        for (int i = 0; i < 5; i++)
        {
            double x = coordinates[i][0];
            double y = coordinates[i][1];

            if (Math.Abs(x) <= A / 2 && Math.Abs(y) <= A / 2) 
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}