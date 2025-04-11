using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int length = num.ToString().Length;

            Console.WriteLine("Length :" + length);
        }
    }
}