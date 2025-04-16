using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("all symmetric numbers from 1000 to 9999 are : ");
            for (int i = 1000; i < 10000; i++)
            {
                int a = i / 1000;
                int b = (i / 100) % 10;
                int c = (i / 10) % 10;
                int d = i % 10;

                if (a == d && b == c)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}