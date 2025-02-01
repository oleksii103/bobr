using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
/*Створіть клас "Місто". 
 * Необхідно зберігати у полях класу: назву міста, назву країни, кількість жителів у місті, 
 * телефонний код міста, назву районів міста. Реалізуйте методи класу для введення даних, виведення даних
 * Реалізуйте доступ до окремих полів через методи класу.*/
namespace ConsoleApp3
{
    public class City
    {  
        public string CityName { get; set; }
        public string Country { get; set; }
        public int HumanValue { get; set; }
        public int CityPhoneCode { get; set; }
        public List<string> RayonName {  get; set; }
        public City(string cityName, string country, int humanValue, int cityPhoneCode, List<string> rayonName)
        {
            CityName = cityName;
            Country = country;
            HumanValue = humanValue;
            CityPhoneCode = cityPhoneCode;
            RayonName = rayonName;
        }
        public City() { }
        public override string ToString()
        {
            string vse = $"city name: {CityName}, country: {Country}, human value: {HumanValue}, city phone code: {CityPhoneCode}, rayon:  ";
            for (int i = 0; i < RayonName.Count; i++) {
                vse += RayonName[i].ToString() + " ";
            }
            return vse;
        }
        public void Sherlok(string data)
        {
            string[] name = data.Split(',');
            CityName = name[0];
            Country = name[1];
            HumanValue = int.Parse(name[2]);
            CityPhoneCode = int.Parse(name[3]);
            RayonName = new List<string>();
            string[] rayon = name[4].Split(';');
            for (int i = 0; i < rayon.Length; i++)
            {
                RayonName.Add(rayon[i]);
            }
           
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            City Lviv = new City("Lviv", "Ukraine", 100000, 322, new List<string> { "ryasne", "ryasne 2" });
            Console.WriteLine(Lviv.ToString());
            City Krakov = new City();
            string data = Console.ReadLine();
            Krakov.Sherlok(data);
            Console.WriteLine(Krakov.ToString());
        }
    }
}
