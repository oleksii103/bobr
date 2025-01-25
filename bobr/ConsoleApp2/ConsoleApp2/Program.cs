using System;
using System.Collections.Generic;

class Program
{
    static int CountSequenceInArray(int[] arr, int[] sequence)
    {
        int count = 0;
        for (int i = 0; i <= arr.Length - sequence.Length; i++)
        {
            bool match = true;
            for (int j = 0; j < sequence.Length; j++)
            {
                if (arr[i + j] != sequence[j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
            {
                count++;
            }
        }
        return count;
    }

    static void GeneratePermutations(string str, int startIndex, int endIndex)
    {
        if (startIndex == endIndex)
        {
            Console.WriteLine(str);  // Виведення перестановки
        }
        else
        {
            for (int i = startIndex; i <= endIndex; i++)
            {
                // Перестановка символів
                str = Swap(str, startIndex, i);
                GeneratePermutations(str, startIndex + 1, endIndex);
                // Повернення символів на місце (для інших перестановок)
                str = Swap(str, startIndex, i);
            }
        }
    }

    // Функція для обміну символів
    static string Swap(string str, int i, int j)
    {
        char[] charArray = str.ToCharArray();
        char temp = charArray[i];
        charArray[i] = charArray[j];
        charArray[j] = temp;
        return new string(charArray);
    }
    static void Main()
    {
        Console.WriteLine("enter task (from 2 to 11)");
        int choise = int.Parse(Console.ReadLine());
        if (choise == 3)
        {
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter {size} numbers for the array (separated by spaces):");
            string[] arrInput = Console.ReadLine().Split();


            int[] arr = Array.ConvertAll(arrInput, int.Parse);

            Console.WriteLine("Enter a sequence of three numbers (separated by spaces):");
            string[] sequenceInput = Console.ReadLine().Split();
            int[] sequence = Array.ConvertAll(sequenceInput, int.Parse);

            if (sequence.Length != 3)
            {
                Console.WriteLine("The sequence must contain exactly three numbers.");
            }
            else
            {
                int result = CountSequenceInArray(arr, sequence);
                Console.WriteLine($"The sequence appears {result} time(s).");
            }
        }
        else if (choise == 2)
        {
            Console.WriteLine("enter array size");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("enter 5 numbers with enter");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int p = 0;
            p = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < p)
                {
                    count++;
                }
            }
            Console.WriteLine($"your array {count}");
            Console.ReadKey();
        }
        else if (choise == 4)
        {
            Console.Write("Enter the size of the first array: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Enter the size of the second array: ");
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[m];
            int[] array2 = new int[n];

            Console.WriteLine("Enter elements of the first array:");
            for (int i = 0; i < m; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter elements of the second array:");
            for (int i = 0; i < n; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            HashSet<int> set1 = new HashSet<int>(array1);
            HashSet<int> set2 = new HashSet<int>(array2);

            set1.IntersectWith(set2);

            int[] result = new int[set1.Count];
            set1.CopyTo(result);

            Console.WriteLine("Common elements:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        else if (choise == 10)
        {
            string b = Console.ReadLine();
            
                Console.WriteLine("Будь ласка, введіть один рядок як аргумент командного рядка.");
                
      

            string inputString = b;
            GeneratePermutations(inputString, 0, inputString.Length - 1);
        }
    }
    
}
