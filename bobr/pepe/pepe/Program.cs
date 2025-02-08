using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pepe
{
    public class Worker : IComparable<Worker>
    {
        public string Rank { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }
        public int salary { get; set; }

        public static bool operator ==(Worker left, Worker right)
        {
            if (left.salary == right.salary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Worker left, Worker right)
        {
            if (left.salary != right.salary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >(Worker left, Worker right)
        {
            if (left.salary > right.salary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Worker left, Worker right)
        {
            if (left.salary < right.salary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Worker operator +(Worker bib, int a)
        {
            bib.salary += a;
            return bib;
        }

        public override string ToString()
        {
            return $"rab info:\n Rank - {Rank}, First name - {FirstName}, Last name - {LastName}, Age - {age}, Salary - {salary}";
        }
        public Worker(string Rank, string FirstName, string LastName, int Age, int Salary)
        {
         
            this.Rank = Rank;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.age = Age;
            this.salary = Salary;
            

        }

        public void CalculateSalary(double stavka, double days)
        {
            double salary = days / CountDays * stavka;
            this.salary = (int)salary;
        }
        public void CalculateSalary(double stavka, int hours)
        {
            double salary = hours * stavka;
            this.salary = (int)salary;
        }

        public void CalculateSalary(double stavka, double days, double premia)
        {
            double salary = days / CountDays * stavka + premia;
            this.salary = (int)salary;
        }


        public void CalculateSalary(double stavka, int hours, double premia)
        {
            double salary = hours * stavka + premia;
            this.salary = (int)salary;
        }

  
        public int CompareTo(Worker other)
        {
            if (this < other)
            {
                return -1;
            }
            else if (this > other)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private const int CountDays = 24;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker rab1 = new Worker("lox", "bib", "bob", 123, -12345);
            Worker rab2 = new Worker("max_lox", "bob", "bib", 34, 2345);
            Worker rab3 = new Worker("pro_max_lox", "boba", "peps", 90, 0);
            rab1 += 5;

            List<Worker> workers = new List<Worker>() {rab1,  rab2, rab3};
            workers.Sort();
            for (int i = 0; i < workers.Count; i++)
            {
                Console.WriteLine(workers[i].ToString());
            }
        }
    }
}
