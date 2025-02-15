using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using boba.Models;

namespace boba //Fett
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Human> PlantWorkers = new List<Human>
            {
                new Human()
                {
                    Name = "Bib",
                    Age = 25,
                    BDay = new DateTime(2000, 1, 20),
                    RabNumber = 56883
                },
                new Pilot()
                {
                    Name = "Ed",
                    Age = 67,
                    BDay = new DateTime(1958, 2, 27),
                    RabNumber = 57001,
                    PlaneId = 74539,
                    ButtonsValue = 66,
                    RedBullInBlood = 99
                    
                },
                new Sailor()
                {
                    Name = "Edvard",
                    Age = 47,
                    BDay = new DateTime(1978, 9, 12),
                    RabNumber = 34567,
                    Job = SeaJobs.Capitan,
                    SeaName = "Black",
                    YearsOnBoat = 34
                },
                new Sailor()
                {
                    Name = "Pedro",
                    Age = 13,
                    BDay = new DateTime(2012, 7, 8),
                    RabNumber = 12345,
                    Job = SeaJobs.Alcoholyk,
                    SeaName = "Black",
                    YearsOnBoat = 13
                },
                new Bilder()
                {
                    Name = "Padre",
                    Age = 17,
                    BDay = new DateTime(2008, 3, 11),
                    RabNumber = 98765,
                    Id = 443,
                    PlantName = "KanabisForAll",
                    СarryingСapacity = 44
                }
                
            };
            int pahat;
            Console.WriteLine("enter Work Time");
            pahat = int.Parse(Console.ReadLine());

            int sum = 0;

            PlantWorkers.ForEach(worker => Console.WriteLine($"Name: {worker.Name} Salary: {worker.Pahat(pahat)}"));
            sum = PlantWorkers.Sum((worker) => { return worker.Pahat(pahat);  });
            Console.WriteLine(sum);
            Array Nani = new Array
            {
                HumanList = PlantWorkers
                
            };
            Nani.SortASC();
            Nani.SortDESC();
            Nani.SortByParam(true);
            Nani.HumanList.ForEach(human => Console.WriteLine(human));
        }
    }
}
