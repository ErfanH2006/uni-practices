using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== Array Exercises =====");
                Console.WriteLine("Select an exercise to run:");
                Console.WriteLine("1. Determine if a specific number exist in an array");
                Console.WriteLine("2. Remove a specefic number from an array (it also include copy an array)");
                Console.WriteLine("3. Insert a number at specific index in array");
                Console.WriteLine("4. Print duplicate elements in an array");
                Console.WriteLine("5. Print duplicate elements between two arrays");
                Console.WriteLine("6. Remove duplicates from an array");
                Console.WriteLine("7. Check if two arrays are equal");
                Console.WriteLine("8. Move all zeroes to end of array");
                Console.WriteLine("9. Shift array counterclockwise");
                Console.WriteLine("10. Move negative numbers to left, positives to right");
                Console.WriteLine("11. Print students with GPA above class average");
                Console.WriteLine("12. Intersect two lists without duplicates");
                Console.WriteLine("13. Print most frequent number in list");
                Console.WriteLine("14. Group student numbers by major code");
                Console.WriteLine("15. Group students by education level");
                Console.WriteLine("16. Calculate variance of decimal numbers");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: DetermineIfNumberExists(); break;
                    case 2: DeleteSpecialNumber(); break;
                    case 3: InsertAtIndex(); break;
                    case 4: PrintDuplicates(); break;
                    case 5: PrintCommonBetweenArrays(); break;
                    case 6: RemoveDuplicates(); break;
                    case 7: CheckArrayEquality(); break;
                    case 8: MoveZeroesToEnd(); break;
                    case 9: ShiftArrayCounterclockwise(); break;
                    case 10: SeparateNegativesAndPositives(); break;
                    case 11: StudentsAboveAverage(); break;
                    case 12: IntersectUniqueLists(); break;
                    case 13: MostFrequentNumber(); break;
                    case 14: GroupByMajorCode(); break;
                    case 15: GroupByEducationLevel(); break;
                    case 16: CalculateVariance(); break;
                    case 0: return;
                    default: Console.WriteLine("Invalid choice."); break;
                }

                Console.WriteLine("Press Enter to return to menu...");
                Console.ReadLine();
            }
        }

        static void DetermineIfNumberExists()
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter number to search for: ");
            int target = int.Parse(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    Console.WriteLine($"The number {target} is found at index {i}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"The number {target} is not found in the array.");
            }
        }


        static void DeleteSpecialNumber()
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter number to remove: ");
            int target = int.Parse(Console.ReadLine());

            int[] newArr = arr.Where(x => x != target).ToArray();

            Console.Write("Array after removal: ");
            foreach (int num in newArr)
            {
                Console.Write(num + " ");
            }
        }

        static void InsertAtIndex()
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size + 1];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter number to insert: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter index to insert at: ");
            int index = int.Parse(Console.ReadLine());

            for (int i = size; i > index; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[index] = num;

            Console.WriteLine("Updated array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void PrintDuplicates()
        {
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            var seen = new HashSet<int>();
            var duplicates = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                int num = int.Parse(Console.ReadLine());
                if (!seen.Add(num))
                {
                    duplicates.Add(num);
                }
            }

            Console.WriteLine("Duplicate elements:");
            foreach (int d in duplicates)
            {
                Console.WriteLine(d);
            }
        }

        static void PrintCommonBetweenArrays()
        {
            Console.Write("Enter size of first array: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter size of second array: ");
            int n2 = int.Parse(Console.ReadLine());

            var set1 = new HashSet<int>();
            var set2 = new HashSet<int>();

            Console.WriteLine("Enter elements for first array:");
            for (int i = 0; i < n1; i++)
                set1.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter elements for second array:");
            for (int i = 0; i < n2; i++)
                set2.Add(int.Parse(Console.ReadLine()));

            var common = set1.Intersect(set2);
            Console.WriteLine("Common elements:");
            foreach (int item in common)
                Console.WriteLine(item);
        }

        static void RemoveDuplicates()
        {
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());
            var list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (!list.Contains(num))
                    list.Add(num);
            }

            Console.WriteLine("Array after removing duplicates:");
            foreach (int num in list)
                Console.Write(num + " ");
        }

        static void CheckArrayEquality()
        {
            Console.Write("Enter size of arrays: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];

            Console.WriteLine("Enter elements of first array:");
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter elements of second array:");
            for (int i = 0; i < n; i++)
                b[i] = int.Parse(Console.ReadLine());

            bool isEqual = a.SequenceEqual(b);
            Console.WriteLine("Arrays are " + (isEqual ? "equal" : "not equal"));
        }

        static void MoveZeroesToEnd()
        {
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            foreach (int num in arr)
                if (num != 0)
                    arr[index++] = num;

            while (index < n)
                arr[index++] = 0;

            Console.WriteLine("Modified array:");
            foreach (int num in arr)
                Console.Write(num + " ");
        }

        static void ShiftArrayCounterclockwise()
        {
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int temp = arr[0];
            for (int i = 0; i < n - 1; i++)
                arr[i] = arr[i + 1];
            arr[n - 1] = temp;

            Console.WriteLine("Shifted array:");
            foreach (int x in arr)
                Console.Write(x + " ");
        }

        static void SeparateNegativesAndPositives()
        {
            Console.Write("Enter array size: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Array.Sort(arr, (x, y) => (x < 0 && y >= 0) ? -1 : (x >= 0 && y < 0) ? 1 : 0);

            Console.WriteLine("Rearranged array:");
            foreach (int num in arr)
                Console.Write(num + " ");
        }

        static void StudentsAboveAverage()
        {
            Console.Write("Enter number of students: ");
            int count = int.Parse(Console.ReadLine());
            string[] names = new string[count];
            string[] ids = new string[count];
            double[] gpas = new double[count];
            double sum = 0;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter name of student {i + 1}: ");
                names[i] = Console.ReadLine();
                Console.Write($"Enter student ID: ");
                ids[i] = Console.ReadLine();
                Console.Write($"Enter GPA: ");
                gpas[i] = double.Parse(Console.ReadLine());
                sum += gpas[i];
            }

            double avg = sum / count;
            Console.WriteLine($"Class average GPA: {avg:F2}");
            Console.WriteLine("Students with GPA above average:");
            for (int i = 0; i < count; i++)
            {
                if (gpas[i] > avg)
                {
                    Console.WriteLine($"{names[i]} ({ids[i]}) - GPA: {gpas[i]}");
                }
            }
        }

        static void IntersectUniqueLists()
        {
            Console.Write("Enter size of first list: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter size of second list: ");
            int n2 = int.Parse(Console.ReadLine());

            var list1 = new HashSet<int>();
            var list2 = new HashSet<int>();

            Console.WriteLine("Enter elements for first list:");
            for (int i = 0; i < n1; i++)
                list1.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter elements for second list:");
            for (int i = 0; i < n2; i++)
                list2.Add(int.Parse(Console.ReadLine()));

            var intersection = list1.Intersect(list2);
            Console.WriteLine("Intersection (no duplicates):");
            foreach (int num in intersection)
                Console.WriteLine(num);
        }

        static void MostFrequentNumber()
        {
            Console.Write("Enter list size: ");
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (frequency.ContainsKey(num))
                    frequency[num]++;
                else
                    frequency[num] = 1;
            }

            var maxItem = frequency.OrderByDescending(x => x.Value).First();
            Console.WriteLine($"Most frequent number: {maxItem.Key} (appeared {maxItem.Value} times)");
        }

        static void GroupByMajorCode()
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> majors = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter student ID: ");
                string id = Console.ReadLine();
                Console.Write("Enter major code: ");
                string major = Console.ReadLine();

                if (!majors.ContainsKey(major))
                    majors[major] = new List<string>();

                majors[major].Add(id);
            }

            foreach (var pair in majors)
            {
                Console.WriteLine($"Major {pair.Key}:");
                foreach (string id in pair.Value)
                    Console.WriteLine($" - {id}");
            }
        }

        static void GroupByEducationLevel()
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, List<string>> levels = new Dictionary<int, List<string>>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter student ID: ");
                string id = Console.ReadLine();
                Console.Write("Enter education level (1: Associate, 2: Bachelor, 3: Master, 4: PhD): ");
                int level = int.Parse(Console.ReadLine());

                if (!levels.ContainsKey(level))
                    levels[level] = new List<string>();

                levels[level].Add(id);
            }

            foreach (var level in levels)
            {
                string label = level.Key switch
                {
                    1 => "Associate",
                    2 => "Bachelor",
                    3 => "Master",
                    4 => "PhD",
                    _ => "Unknown"
                };

                Console.WriteLine($"{label}:");
                foreach (string id in level.Value)
                    Console.WriteLine($" - {id}");
            }
        }

        static void CalculateVariance()
        {
            Console.Write("Enter number of values: ");
            int n = int.Parse(Console.ReadLine());
            double[] values = new double[n];
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter value {i + 1}: ");
                values[i] = double.Parse(Console.ReadLine());
                sum += values[i];
            }

            double mean = sum / n;
            double variance = values.Select(val => Math.Pow(val - mean, 2)).Sum() / n;

            Console.WriteLine($"Variance: {variance:F2}");
        }
    }
}