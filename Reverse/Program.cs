using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            string num = Console.ReadLine();

            char[] reversedArray = num.ToCharArray();
            Array.Reverse(reversedArray);

            string reversedNumber = new string(reversedArray);
            Console.WriteLine("reversed number : "+ reversedNumber );
        }
    }
}