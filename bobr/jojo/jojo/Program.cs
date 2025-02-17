using System;
using System.Linq;

namespace jojo
{
    internal class Program
    {
        class CaesarCipher
        {
            public static string Encrypt(string text, int shift)
            {
                string result = "";
                foreach (char ch in text)
                {
                    if (char.IsLetter(ch))
                    {
                        char shiftBase = char.IsUpper(ch) ? 'A' : 'a';
                        result += (char)((ch - shiftBase + shift) % 26 + shiftBase);
                    }
                    else
                    {
                        result += ch;
                    }
                }
                return result;
            }

            public static string Decrypt(string text, int shift)
            {
                return Encrypt(text, -shift);
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Select the task number:");
                Console.WriteLine("1. Task 1 (Array Operations)");
                Console.WriteLine("2. Task 3 (Caesar Cipher)");
                Console.WriteLine("3. Task 9 (Array Multiplication)");
                int taskChoice = int.Parse(Console.ReadLine());

                switch (taskChoice)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task3();
                        break;
                    case 3:
                        Task9(args);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }

            static void Task1()
            {
                int[] A = new int[5];
                double[,] B = new double[3, 4];
                Random rand = new Random();

                Console.WriteLine("Enter 5 elements for array A (through enter):");
                for (int i = 0; i < A.Length; i++)
                {
                    A[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        B[i, j] = Math.Round(rand.NextDouble() * 100, 2);
                    }
                }

                Console.WriteLine("Array A:");
                foreach (int num in A)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();

                Console.WriteLine("Array B:");
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        Console.Write(B[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                double max = A[0], min = A[0], sum = 0, product = 1;
                foreach (int num in A)
                {
                    if (num > max) max = num;
                    if (num < min) min = num;
                    sum += num;
                    product *= num;
                }

                foreach (double num in B)
                {
                    if (num > max) max = num;
                    if (num < min) min = num;
                    sum += num;
                    product *= num;
                }

                int sumEvenA = 0;
                foreach (int num in A)
                {
                    if (num % 2 == 0) sumEvenA += num;
                }

                double sumOddColumnsB = 0;
                for (int j = 1; j < B.GetLength(1); j += 2)
                {
                    for (int i = 0; i < B.GetLength(0); i++)
                    {
                        sumOddColumnsB += B[i, j];
                    }
                }

                Console.WriteLine($"Maximum element: {max}");
                Console.WriteLine($"Minimum element: {min}");
                Console.WriteLine($"Total sum: {sum}");
                Console.WriteLine($"Total product: {product}");
                Console.WriteLine($"Sum of even elements in array A: {sumEvenA}");
                Console.WriteLine($"Sum of elements in odd columns of array B: {sumOddColumnsB}");
            }

            static void Task3()
            {
                Console.Write("Enter your text: ");
                string text = Console.ReadLine();
                Console.Write("Enter the offset: ");
                int shift = int.Parse(Console.ReadLine());

                string encrypted = Encrypt(text, shift);
                string decrypted = Decrypt(encrypted, shift);

                Console.WriteLine($"Coded text: {encrypted}");
                Console.WriteLine($"Decoded text: {decrypted}");
            }

            static void Task9(string[] args) //sorry i can`t my version garbage, gpt version is garbage, copilot versoin is garbage  
            {
                if (args.Length < 3)
                {
                    Console.WriteLine("Please provide three arguments: number of rows, number of columns, and the multiplier.");
                    return;
                }

                int rows = int.Parse(args[0]);
                int cols = int.Parse(args[1]);
                int multiplier = int.Parse(args[2]);

                int[,] array = new int[rows, cols];
                Random rand = new Random();

                Console.WriteLine("Original Array:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        array[i, j] = rand.Next(1, 10); 
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"Array after multiplication by {multiplier}:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        array[i, j] *= multiplier;
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
//I wrote the task, chat jpt only added a choice between them and task 9
