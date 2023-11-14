using System;

namespace task9
{
    class Task9
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

            string[] pointCoordinates = Console.ReadLine().Trim().Split();
            double xPoint = double.Parse(pointCoordinates[0]);
            double yPoint = double.Parse(pointCoordinates[1]);
            double radius = double.Parse(pointCoordinates[2]);

            for (int i = 0; i < 5; i++)
            {
                double x = coordinates[i][0];
                double y = coordinates[i][1];

                bool isInside = IsInsideCircle(x, y, xPoint, yPoint, radius);

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

        static bool IsInsideCircle(double x, double y, double xPoint, double yPoint, double radius)
        {
            double distance = Math.Sqrt(Math.Pow(x - xPoint, 2) + Math.Pow(y - yPoint, 2));
            return distance <= radius;
        }
    }
}