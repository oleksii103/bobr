using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boba.Models
{
    internal class Pilot : Human
    {
        public int PlaneId { get; set; }
        public int RedBullInBlood { get; set; }
        public int ButtonsValue { get; set; }


        public override int Pahat(int WorkTime)
        {
            if (RedBullInBlood < 100)
            {
                int Salary = WorkTime * ButtonsValue - RedBullInBlood;
                return Salary;
            }
            else
            {
                Console.WriteLine("He is dead");
                return 0;
            }
        }
    }
}
