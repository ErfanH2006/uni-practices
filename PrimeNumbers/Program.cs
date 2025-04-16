using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                                                // Check if the number is prime or not

            Console.WriteLine("Enter a number to check if it is prime:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;

            if (number < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }

            

                                                                    // Find all prime numbers up to a given number


            Console.WriteLine("Enter a number to find all prime numbers up to that number:");
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Prime numbers up to {limit}:");

            for (int i = 2; i <= limit; i++)
            {
                isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(i + " ");
                }

            }
        }
    }
}