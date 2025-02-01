using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter math expration");
            string expration = Console.ReadLine();
            string[] mark = expration.Split('*');
            int result = 1;
            for (int i = 0; i < mark.Length; i++) 
            {
                result = int.Parse(mark[i])*result;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
