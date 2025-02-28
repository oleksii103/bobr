using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//here`s task 1 & task 3

namespace HW6
{
    public interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }

    public interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }

    public class Array : ICalc, ICalc2
    {
        private int[] elements;

        public Array(int[] elements)
        {
            this.elements = elements;
        }

        public int Less(int valueToCompare)
        {
            return elements.Count(e => e < valueToCompare);
        }

        public int Greater(int valueToCompare)
        {
            return elements.Count(e => e > valueToCompare);
        }

        public int CountDistinct()
        {
            return elements.Distinct().Count();
        }

        public int EqualToValue(int valueToCompare)
        {
            return elements.Count(e => e == valueToCompare);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array array = new Array(numbers);

            Console.Write("Enter the value to compare: ");
            int valueToCompare = int.Parse(Console.ReadLine());

            Console.WriteLine($"Number of elements less than {valueToCompare}: {array.Less(valueToCompare)}");
            Console.WriteLine($"Number of elements greater than {valueToCompare}: {array.Greater(valueToCompare)}");
            Console.WriteLine($"Number of distinct elements: {array.CountDistinct()}");
            Console.WriteLine($"Number of elements equal to {valueToCompare}: {array.EqualToValue(valueToCompare)}");
        }
    }
}
