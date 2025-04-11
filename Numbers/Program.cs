using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

                                                                            // Get 20 numbers and return the smallest
            /*int[] numbers = new int[20];
            int smallest;

            Console.WriteLine("Enter 20 numbers :");

            for (int i = 0; i < 20; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            smallest = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }

            Console.WriteLine($"The smallest number is: {smallest}");*/



                                                                            // Get 20 numbers and return the biggest

            /*int[] number = new int[20];
            int biggest;

            Console.WriteLine("Enter 20 numbers :");

            for (int i = 0; i < 20; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }

            biggest = number[0];

            for (int i = 1; i < number.Length; i++)
            {
                if (number[i] > biggest)
                {
                    biggest = number[i];
                }
            }

            Console.WriteLine($"The biggest number is: {biggest}");*/
            


                                                                            // Get 20 numbers and return the average

            int[] number = new int[20];
            int sum = 0 ;
            double average;

            Console.WriteLine("Enter 20 numbers :");

            for (int i = 0; i < 20; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i];
            }

            average = (double)sum / number.Length;

            Console.WriteLine($"The average og the numbers is: {average}");






                                                                            // Get 20 numbers and return the numbers that ends with 5
            /*int[] number = new int[20];

            Console.WriteLine("Enter 20 numbers :");

            for (int i = 0; i < 20; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < number.Length; i++)
            {
                
                if (number[i] % 10 == 5)
                {
                    Console.Write(" - ");
                    Console.WriteLine(number[i]);
                }
            }*/

        }   
    }
}
