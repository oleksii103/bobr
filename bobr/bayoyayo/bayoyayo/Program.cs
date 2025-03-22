using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bayoyayo
{
    public class House : IEnumerable<Flats>
    {
        public int Number { get; set; }
        public int Rooms { get; set; }
        public int FlatsValue { get; set; }
        public List<Flats> Flats { get; set; }

        public IEnumerator<Flats> GetEnumerator()
        {
            for (int i = 0; i < Flats.Count; i++)
            {
                yield return Flats[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return GetEnumerator();
        }
    }

    public class Tenant
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            string a = $"name: {Name}, age: {Age}";
            return a ;
        }
    }

    public class Flats : IEnumerable<Tenant> 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Value { get; set; }
        public List<Tenant> Tenants { get; set; } = new List<Tenant>();

        public override string ToString()
        {
            string a = $"name: {Name}, age: {Age}, value {Value}";
            for (int i = 0;i < Tenants.Count; i++)
            {
                Tenant t = Tenants[i];
                a += t.ToString();
            }
            return a;
        }
        public IEnumerator<Tenant> GetEnumerator()
        {
            for(int i = 0; i < Tenants.Count; i++) { 
                yield return Tenants[i]; 
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
          return GetEnumerator();
        }
    }
    public class Alphabet : IEnumerable<char>
    {
        char[] Bukavs = new char[26];
        public Alphabet()
        {
            char bukava = 'A';
            int i = 0;
            while (bukava <= 'Z')
            {
                Bukavs[i] = bukava;
                i++;
                bukava++;
            }
        }

        public IEnumerator<char> GetEnumerator()
        {
            for (int i = 0; i < Bukavs.Length; i++)
            {
                yield return Bukavs[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            /* task1
           Alphabet Ali = new Alphabet();
            foreach (char c in Ali)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();
            */
            List<House> houses = new List<House>
            {
                new House { Number = 1, Rooms = 5, FlatsValue = 10 },
                new House { Number = 2, Rooms = 3, FlatsValue = 6 },
                new House { Number = 3, Rooms = 4, FlatsValue = 8 }
            };

            List<Flats> flats1 = new List<Flats>
            {
                new Flats
                {
                    Name = "Flat 1", Age = 10, Value = 50000,
                    Tenants = new List<Tenant>
                    {
                        new Tenant { Name = "Oleksandr", Age = 30 },
                        new Tenant { Name = "Maria", Age = 25 }
                    }
                },
                new Flats
                {
                    Name = "Flat 2", Age = 5, Value = 60000,
                    Tenants = new List<Tenant>
                    {
                        new Tenant { Name = "Billy", Age = 40 }
                    }
                },
                new Flats
                {
                    Name = "Flat 3", Age = 15, Value = 45000,
                    Tenants = new List<Tenant>
                    {
                        new Tenant { Name = "Masha", Age = 35 },
                        new Tenant { Name = "Pedro", Age = 28 }
                    }
                }
            };
            List<Flats> flats2 = new List<Flats>
            {
                new Flats
                {
                    Name = "Flat 1", Age = 10, Value = 50000,
                    Tenants = new List<Tenant>
                    {
                        new Tenant { Name = "Garic", Age = 30 },
                        new Tenant { Name = "Maria", Age = 25 }
                    }
                },
                new Flats
                {
                    Name = "Flat 2", Age = 5, Value = 60000,
                    Tenants = new List<Tenant>
                    {
                        new Tenant { Name = "Huan", Age = 40 }
                    }
                },
                new Flats
                {
                    Name = "Flat 3", Age = 15, Value = 45000,
                    Tenants = new List<Tenant>
                    {
                        new Tenant { Name = "Nick", Age = 35 },
                        new Tenant { Name = "Anjey", Age = 28 }
                    }
                }
            };
            List<Flats> flats3 = new List<Flats>
            {
                new Flats
                {
                    Name = "Flat 1", Age = 10, Value = 50000,
                    Tenants = new List<Tenant>
                    {
                        new Tenant { Name = "Garic", Age = 30 },
                        new Tenant { Name = "Leonid", Age = 25 }
                    }
                },
                new Flats
                {
                    Name = "Flat 2", Age = 5, Value = 60000,
                    Tenants = new List<Tenant>
                    {
                        new Tenant { Name = "Padre", Age = 40 }
                    }
                },
                new Flats
                {
                    Name = "Flat 3", Age = 15, Value = 45000,
                    Tenants = new List<Tenant>
                    {
                        new Tenant { Name = "Sergey", Age = 35 },
                        new Tenant { Name = "Lofffffff", Age = 28 }
                    }
                }
            };
            houses[0].Flats = flats1;
            houses[1].Flats = flats2;
            houses[2].Flats = flats3;

            foreach (var house in houses)
            {
                foreach (Flats bib in house)
                {
                    Console.WriteLine(bib);
                }
                
            }
        
        }
    }
}
