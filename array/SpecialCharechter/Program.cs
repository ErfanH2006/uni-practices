using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of elements in the array: ");
            
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];

            Console.WriteLine($"please enter {size} numbers: ");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the number to search for: ");
            int target = int.Parse(Console.ReadLine());

            bool isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    Console.WriteLine($"The number {target} is found at index {i}");
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine($"The number {target} is not found in the array.");
            }
        }
    }
}
