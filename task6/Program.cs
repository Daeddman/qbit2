using System;
namespace task6;

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

        string[] ab = Console.ReadLine().Trim().Split();
        double a = double.Parse(ab[0]);
        double b = double.Parse(ab[1]);

        for (int i = 0; i < 5; i++)
        {
            double x = coordinates[i][0];
            double y = coordinates[i][1];

            bool isInside = IsInsideTrip(x, y, a, b);
            if (isInside)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }

    static bool IsInsideTrip(double x, double y, double a, double b)
    {
        if ((x >= a && x <= b) | (x >= b && x <= a))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}