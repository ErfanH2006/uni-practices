using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < number; i++)
            {
                if ( i == 1 || i % 2 == 0)
                {
                    result += i;
                }
                else
                {
                    result -= i;
                }
                Console.WriteLine($"The result is {result}");
            }
        }
    }
}