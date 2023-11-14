using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 3 == 0 && number % 2 != 0 && number % 5 != 0)
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