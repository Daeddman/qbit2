using System;

namespace task10
{
    class Task10
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Trim().Split();
            int x = int.Parse(input1[0]);
            int y = int.Parse(input1[1]);
            int x1 = int.Parse(input1[2]);
            int y1 = int.Parse(input1[3]);
            string[] input2 = Console.ReadLine().Trim().Split();
            int x2 = int.Parse(input2[0]);
            int y2 = int.Parse(input2[1]);
            int x3 = int.Parse(input2[2]);
            int y3 = int.Parse(input2[3]);
            
            double r1FirstPointX = Math.Min(x, x1);
            double r1SecondPointX = Math.Max(x, x1);
            double r1FirstPointY = Math.Min(y, y1);
            double r1SecondPointY = Math.Max(y, y1);
            
            double r2FirstPointX = Math.Min(x2, x3);
            double r2SecondPointX = Math.Max(x2, x3);
            double r2FirstPointY = Math.Min(y2, y3);
            double r2SecondPointY = Math.Max(y2, y3);
            
            
            double width = Math.Max(0, Math.Min(r1SecondPointX, r2SecondPointX) - Math.Max(r1FirstPointX, r2FirstPointX));
            double height = Math.Max(0, Math.Min(r1SecondPointY, r2SecondPointY) - Math.Max(r1FirstPointY, r2FirstPointY));
                double area = width * height;
                Console.WriteLine(area);
            
        }
    }
}