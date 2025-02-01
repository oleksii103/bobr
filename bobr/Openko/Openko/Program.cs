using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace ConsoleApp3
{
    internal class Program
    {
        static List<int> NumbersFromConsole()
        {
            Console.WriteLine("entr your numbers");
            string numbersInString = Console.ReadLine();
            string[] numbersInArray = numbersInString.Split(' ');
            List<int> numbers = new List<int>();
            for (int i = 0; i < numbersInArray.Length; i++)
            {
                try
                {
                    numbers.Add(int.Parse(numbersInArray[i]));
                }
                catch (FormatException)
                {
                    Console.WriteLine("wrong number");


                }
            }
            return numbers;


        }

        static int BinaryToNormal()
        {

            Console.WriteLine("Enter your 1 and 0 numbers: ");
            string BiN = Console.ReadLine();
            List<int> Bi = new List<int>();

            for (int i = 0; i < BiN.Length; i++)
            {
                int? tmp = null;
                try
                {
                    Bi.Add(int.Parse(BiN[i].ToString()));
                }
                catch (Exception)
                {
                    Console.WriteLine(BiN[i].ToString());
                    Console.WriteLine("wront argument");
                }
                if (tmp != null && tmp <= 1) {

                }

                Bi.Add((int)tmp);
            }
        }
        int finalNumber = 0; 
        static void Main(string[] args)
        {
            #region first
            List<int> numbers = NumbersFromConsole();
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            #endregion
        }
    }
}
//unfinished