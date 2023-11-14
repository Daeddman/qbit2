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

        string[] pointCoordinates = Console.ReadLine().Trim().Split();
        double x1 = double.Parse(pointCoordinates[0]);
        double y1 = double.Parse(pointCoordinates[1]);
        double x2 = double.Parse(pointCoordinates[2]);
        double y2 = double.Parse(pointCoordinates[3]);
        for (int i = 0; i < 5; i++)
        {
            double x = coordinates[i][0];
            double y = coordinates[i][1];
            if (x1 > x2)
            {
                (x1, x2) = (x2, x1);
            }

            if (y1 > y2)
            {
                (y1, y2) = (y2, y1);
            }

            if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
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