using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Worker
    {
        public string Rank {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }
        public Worker(string Rank, string FirstName, string LastName, int Age) {
            this.Rank = Rank;
            this.FirstName = FirstName;
            this.LastName = LastName;   
            this.age = Age;
            
        }
        public (double, string) CalculateSalary(double stavka, double days)
        {
            double salary = days / CountDays * stavka;
            return (salary, "not z premia");
        }
        public (double, string) CalculateSalary(double stavka, int hours)
        {
            double salary = hours * stavka;
            return (salary, "not z shtraf");
        }

        public (double, string) CalculateSalary(double stavka, double days, double premia)
        {
            double salary = days / CountDays * stavka + premia;
            if (premia > 0)
            {
                return (salary, "z premia");
            }
            else
            {
                return (salary, "z shtraf");
            }
           
        }
        public (double, string) CalculateSalary(double stavka, int hours, double premia)
        {
            double salary = hours * stavka + premia;
            if (premia > 0)
            {
                return (salary, "z premia");
            }
            else
            {
                return (salary, "z shtraf");
            }
        }

        private const int CountDays = 24;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker rab = new Worker("sir", "oleksii", "petriv", 16);
            (double, string) Calc1 = rab.CalculateSalary(80, -4);
            Console.WriteLine(Calc1);
            (double, string) Calc2 = rab.CalculateSalary(5000, 6.0, -300);
            Console.WriteLine(Calc2);
            Console.ReadLine();
        }
    }
}
