using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bambuk
{
    internal class Program
    {
        public static IEnumerable<T> FilterByTwoCriteria<T>(IEnumerable<T> Yetty, Func<T, bool> Pred1, Func<T, bool> Pred2)
        {
            List<T> list = new List<T>();
            for (int i = 0; i < Yetty.Count(); i++)
            {
                if (Pred1(Yetty.ElementAt(i)) && Pred2(Yetty.ElementAt(i)))
                {
                    list.Add(Yetty.ElementAt(i));
                    
                }
            }
            return list;
        }

        public static T GenMin<T>(T n1, T n2, T n3) where T : IComparable<T>
        {
            T MinN = n1;
            if (MinN.CompareTo(n2) == 1)
            {
                MinN = n2;
                if (MinN.CompareTo(n3) == 1)
                {
                    MinN = n3;
                }
            }
            else if (MinN.CompareTo(n3) == 1)
            {
                MinN = n3;

            }
            return MinN;
        }
        public static int MinNumber (int n1, int n2, int n3)
        {
            int MinN = n1;
            if (MinN > n2)
            {
                MinN = n2;
                if (MinN > n3)
                {
                    MinN = n3;
                }
            }
            else if (MinN > n3)
            {
                MinN = n3;

            }
            return MinN;
        }
        static void Main(string[] args)
        {
            /*task Markian
                int size = Int32.Parse(Console.ReadLine());
                int num;
                int[] arr = new int[size];

                for (int i = 0; i < size; i++)
                {
                    num = Int32.Parse(Console.ReadLine());
                    arr[i] = num;
                }

                Func<int[], (int, int)> max = (arr2) =>
                {
                    int maxElem = 0;
                    int Index = 0;
                    for (int i = 0; i < arr2.Length; i++)
                    {
                        if (arr2[i] > maxElem)
                        {
                            Index = i;
                            maxElem = arr2[i];
                        }

                    }
                    return (Index, maxElem);
                };

                var result = max(arr);

                Console.WriteLine(result);
                Console.ReadLine();
           */

            /*task Nazar Kitchak
            Func<int, string> biber = (number) =>
            {
                if (number % 2 == 0) return "parne";

                else return "neparne";
                         
            };
            Console.WriteLine(biber(2));
            Console.WriteLine(biber(5));

            int kf = Int32.Parse(Console.ReadLine());
            Console.WriteLine(biber(kf));
            Console.ReadLine();
            */

            /*task Matviy 
             * Func<int, int, double> bubu = (x, y) => Math.Pow(x, y);

            Console.WriteLine(bubu(2, 32));
            Console.ReadLine();
            */

            /*Mein Task (task 7)
            Console.Write("Enter arr size: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter arr element:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            var oddNumbers = arr.Where(num => num % 2 != 0).ToArray();

            Console.WriteLine("Neparne: ");
            Console.WriteLine(string.Join(", ", oddNumbers)); 
            */

            /*task generik Min
            Console.WriteLine(MinNumber(1, 2, 3));
            Console.WriteLine(MinNumber(2, 3, 1));
            Console.WriteLine(MinNumber(3, 1, 2));
            Console.WriteLine(MinNumber(3, 2, 1));

            Console.WriteLine("enother method");
            Console.WriteLine(GenMin<int>(5, 2, 97));
            */
            List<int> list = new List<int>() { 1, 4, 90, 567, 3456, 2 };
             
            List<int>NList = FilterByTwoCriteria<int>(list, num => num % 2 == 0, num => num > 0 && num < 10).ToList();
            for (int i = 0; i < NList.Count; i++)
            {
                Console.WriteLine(NList[i]);
            }
            List<String> strings = new List<String>() { "ass", "anatolii", "mhgfr", "lkjhgfds", "add" };
            List<string> SList = FilterByTwoCriteria<string>(strings, str=> str.Length <= 3, str=> str.StartsWith("a")).ToList();
            for (int i = 0; i < SList.Count; i++)
            {
                Console.WriteLine(SList[i]);
            }
        }
    }
}
