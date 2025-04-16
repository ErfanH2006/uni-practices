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
                                                // The pattern of first loop is : 1+2-3+4-5+6-7+8-9+10 . . . 
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


                                                // The pattern of second loop is : 1 + 1/2 + 1/3 + 1/N  . . .

            Console.WriteLine("Enter a number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            double sum = 0;

                for (int i = 1; i < number; i++)
                {
                    sum += 1.0 / i; 
                }
                Console.WriteLine($"The result is {sum}");

                Console.ReadKey();
        }
        
    }
}