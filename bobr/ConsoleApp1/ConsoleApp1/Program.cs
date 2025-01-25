using System;
using System.Net.NetworkInformation;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Convert(string F)
        {
            int N = 0;
            for (int i = 0; i < F.Length; i++)
            {
                if (F[i] == '0')
                {
                    N += 0;
                }
                else if (F[i] == '1')
                {
                    N += 1;
                }
                else if (F[i] == '2')
                {
                    N += 2;
                }
                else if (F[i] == '3')
                {
                    N += 3;
                }
                else if (F[i] == '4')
                {
                    N += 4;
                }
                else if (F[i] == '5')
                {
                    N += 5;
                }
                else if (F[i] == '6')
                {
                    N += 6;
                }

                else if (F[i] == '7')
                {
                    N += 7;
                }
                else if (F[i] == '8')
                {
                    N += 8;
                }
                else if (F[i] == '9')
                {
                    N += 9;
                }
                if (i != F.Length - 1)
                {
                    N *= 10;
                }
            }
            return N;
        }
        static void Main(string[] args)
        {
            Console.Write("what task from 0 to 4 you want?:");
            int choise = int.Parse(Console.ReadLine());

            if (choise == 0)
            {
                Console.WriteLine("hello bobr");
                Console.WriteLine("write the number");
                int N = 0;
                string F;
                F = Console.ReadLine();
                //N = Convert(F);
                N = int.Parse(F);
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                        Console.Write(' ');

                    }
                    Console.Write('\n');
                }

                Console.WriteLine("hello bobr");
                Console.WriteLine(N);
                Console.ReadLine();
            }
            else if (choise == 1)
            {
                Console.WriteLine("It's easy to win forgiveness for being wrong;");
                Console.WriteLine("    being right is what gets you into real trouble.");
                Console.WriteLine("Bjarne Stroustrup");
                Console.ReadLine();
            }
            else if (choise == 2)
            {
                int[] numbers = new int[5];

                Console.WriteLine("Enter 5 numbers:");

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"Num {i + 1}: ");
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                int min = numbers[0];
                int max = numbers[0];
                int sum = 0;
                int product = 1;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                    sum += numbers[i];
                    product *= numbers[i];
                }
                Console.WriteLine($"sum fo numbers: {sum}, min number: {min}, max number: {max}, product of numbers: {product}");
                Console.ReadLine();
            }
            else if (choise == 3) {
                Console.WriteLine("enter a six-digit number");
                string input = Console.ReadLine();

                if(input.Length == 6 && int.TryParse(input, out int number))
                {
                    char[] reverse = input.ToCharArray();
                    Array.Reverse(reverse);
                    string RevString = new string(reverse);
                    Console.WriteLine($"osiginal line: {input}, reversed line: {RevString}");
                }
                else
                {
                    Console.WriteLine("please enter six-digit number");                
                }
                Console.ReadLine();
            }
            else if(choise == 4)
            {
                Console.WriteLine("enter range limits");
                Console.WriteLine("enter lower bount: ");
                int lowerBound = int.Parse(Console.ReadLine());

                Console.WriteLine("enter upper bount: ");
                int upperBound = int.Parse(Console.ReadLine());

                int a = 0, b = 1;

                Console.WriteLine($"Fibonachi numbers from {lowerBound} to {upperBound}:");

                while (a <= upperBound)
                {
                    if (a >= lowerBound)
                    {
                        Console.Write($"{a}, " +
                            $"");
                    }
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
            }
            else
            {
                Console.WriteLine("incorrect number");
                Console.ReadLine();
            }
        }
    }
}
