using System;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number :");

            int number = int.Parse(Console.ReadLine());

            int Factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                Factorial *= i;
            }
            Console.WriteLine(Factorial);
        }
    }
}