using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boba/*fett*/.Models
{
    internal class Human
    {
        public override string ToString()
        {
            return $"Name: {Name}, Rab Number: {RabNumber}";
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BDay { get; set;}
        public int RabNumber { get; set;}

        public virtual int Pahat(int WorkTime)
        {
            if (WorkTime <= 8)
            {
                int Salary = WorkTime * 2;
                return Salary;

            }
            else
            {
                Console.WriteLine("stop working beach");
            }
            return 0;
        }

    }
}
