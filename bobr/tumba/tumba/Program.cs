using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Services;
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;

namespace tumba
{
    internal class Program
    {
        static void Out(List<int> boba)
        {
            for (int i = 0; i < boba.Count; i++)
            {
                Console.WriteLine(boba[i]);
            }
        }
        static void Main(string[] args)
        {
            /*  task6
            string PIB;
            Console.WriteLine("enter your first name, last name and father name");
            PIB = Console.ReadLine();
            string PIBcheck = @"^[a-zA-Z]+\s[a-zA-Z]+\s[а-яА-ЯІіЇїЄєҐґ]+$";
            if (Regex.IsMatch(PIB, PIBcheck))
            {
                Console.WriteLine(PIB);
            }
            else
            {
                Console.WriteLine("get out man");
            }
            Console.ReadLine();
            */
            /*
            List<int> boba = new List<int>(){
                84, 47, 46, 65, 45, 16, 24, 72, 18, 35, 13, 28, 94, 86, 80, 1, 85, 21, 5, 4
            };
            Out(boba);
            
            List<int> Parara = boba.Where(x => x % 2 == 0).ToList();
            Out(Parara);
            
            List<int> NoParara = boba.Where(x => x % 2 != 0).ToList();
            Out(NoParara);
            
            Console.WriteLine("enter Numabar");
            int a = int.Parse(Console.ReadLine());
            List<int>Higher = boba.Where(x => x > a).ToList();
            Out(Higher);

            Console.WriteLine("enter 2 numbers");
            int Min = int.Parse(Console.ReadLine());
            int Max = int.Parse(Console.ReadLine());
            List<int> Dio = boba.Where((x) => x > Min && x < Max).ToList();
            Out(Dio);

            List<int> Seven = boba.Where(x => x % 7 == 0).OrderBy((x) => { return x; }).ToList();
            Out(Seven);

            List<int> Eight = boba.Where(x => x % 8 == 0).OrderByDescending(x => x).ToList();
            Out(Eight);
            */
            List<int> list = new List<int>();
            var rnd = new Random();
            for (int i = 0; i <= 9; i++)
            {
                list.Add(rnd.Next(-25, 25));
            } 
            Out(list);
            Console.WriteLine(list.All((x) => x % 2 == 0).ToString());
            Console.WriteLine(list.All((x) => x > 10 && x < 45).ToString());
            Console.WriteLine(list.Any((x) => x < 0).ToString());
            Console.WriteLine(list.Any(x => x < 0 && x % 2 != 0).ToString());
            Console.WriteLine(list.Contains( 7 ).ToString());
            Console.WriteLine(list.FirstOrDefault(x => x > 7).ToString());
            Console.WriteLine(list.LastOrDefault(x => x < 0).ToString());
            Console.ReadLine();
        }
    }
}
