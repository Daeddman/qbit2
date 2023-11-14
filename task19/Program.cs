using System;

namespace task19
{
    class Task19
    {
        static void Main()
        {
            string[] inputs = new string[5];

            for (int i = 0; i < 5; i++)
            {
                inputs[i] = (Console.ReadLine());
            }

            foreach (string item in inputs)
            {
                if (Convert.ToBoolean(item) )
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
}
