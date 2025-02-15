using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boba.Models
{
    internal class Bilder : Human
    {
        public int Id { get; set; }
        public string PlantName { get; set; }
        public int СarryingСapacity {  get; set; }

        public override int Pahat(int WorkTime)
        {
            if (DateTime.Now.Hour > 23 || DateTime.Now.Hour < 9)
            {
                Console.WriteLine("stop working beach");
                return 0;
            }
            else
            {
                int Salary = СarryingСapacity * WorkTime;
                return Salary;
            }
        }
    }

}
