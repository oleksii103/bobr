using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bib
{
    internal class test
    {
        static int NumberMethod(int start, int end)
        {
            int result = 1;
            for (int i = start; i <= end; i++)
            {
                result += 1;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int Metod = NumberMethod(1, 3);
            Console.WriteLine(Metod);
        }
    }
}
