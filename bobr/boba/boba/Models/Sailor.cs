using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boba.Models
{
    public enum SeaJobs
    {
        Alcoholyk,
        Sanitazer,
        Capitan,
        Lox,
        Cook
    }
    internal class Sailor : Human
    {
        public string SeaName { get; set; }
        public int YearsOnBoat { get; set; }
        public SeaJobs Job { get; set; }

        public override int Pahat(int WorkTime)
        {
            switch (Job)
            {
                case SeaJobs.Alcoholyk:
                    int Salary = YearsOnBoat * -1;
                    return Salary;
                case SeaJobs.Sanitazer:
                    Salary = YearsOnBoat * WorkTime * 2;
                    return Salary;
                case SeaJobs.Capitan:
                    Salary = YearsOnBoat * WorkTime * 100;
                    return Salary;
                case SeaJobs.Lox:
                    Salary = YearsOnBoat * WorkTime * 0;
                    return Salary;
                case SeaJobs.Cook:
                    Salary = YearsOnBoat * 100;
                    return Salary;
            }
            return 0;
        }
    }
}
