using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose a task:");
                Console.WriteLine("1 - FizzBuzz");
                Console.WriteLine("2 - Form a number from four digits");
                Console.WriteLine("3 - Check if a number is perfect");
                Console.WriteLine("0 - Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Error: Invalid choice. Try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        FizzBuzz();
                        break;
                    case 2:
                        FormNumber();
                        break;
                    case 3:
                        CheckPerfectNumber();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Error: Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void FizzBuzz()
        {
            Console.Write("Enter a number (1-100): ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number < 1 || number > 100)
                {
                    Console.WriteLine("Error: Number out of range (1-100). Try again.");
                }
                else if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            }
        }

        static void FormNumber()
        {
            Console.Write("Enter four digits (separated by spaces): ");
            string[] input = Console.ReadLine().Split(' ');
            if (input.Length == 4 && int.TryParse(string.Concat(input), out int result))
            {
                Console.WriteLine("Formed number: " + result);
            }
            else
            {
                Console.WriteLine("Error: Please enter exactly four digits.");
            }
        }

        static void CheckPerfectNumber()
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number > 0)
            {
                if (IsPerfectNumber(number))
                {
                    Console.WriteLine($"{number} is a perfect number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a perfect number.");
                }
            }
            else
            {
                Console.WriteLine("Error: Please enter a valid positive number.");
            }
        }

        static bool IsPerfectNumber(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            return sum == num;
        }
    }
}
