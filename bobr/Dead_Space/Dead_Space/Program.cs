using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Dead_Space
{
    public enum Сuisine
    {
        Ukranian,
        American,
        Chinise,
        Japanice,
        Brasilian,
        Indian,
        Mexican
    }

    public enum Type1
    {
        Soop,
        Salad,
        Dessert /*eagle "pow pow baby"*/,
        SecondCourse,
        Snack
    }
    public class Recipe
    {
        public string Name { get; set; }
        public Сuisine cuisine { get; set; }
        public double Time { get; set; }
        public List<string> Steps { get; set; }
        public Type1 type1 { get; set; }
        public Dictionary <string, (int, int)> Ingridients { get; set; }
    }

    public class RecipeBook : IEnumerable<Recipe>, IDisposable
    {
        public List<Recipe> recipes = new List<Recipe>();
        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        } 
        public void DeleteRecipe(string Name)
        {
            Recipe a = recipes.Find((name) => { return name.Name == Name; });
            recipes.Remove(a);
        }

        public List<Recipe> FindRecepe()
        {

            if (recipes.Count != 0)
            {

                var b = recipes[0].GetType().GetProperties();
                for (int i = 0; i < b.Length; i++)
                {
                    if (b[i].Name != "Ingridients")
                    {
                        Console.WriteLine(b[i].Name);
                    }
                }
                
                Console.WriteLine("enter search paramether: ");                
                string BB = Console.ReadLine();
                Console.WriteLine("enter what to find");
                string KK = Console.ReadLine();
                return recipes.FindAll((param) => { return param.GetType().GetProperty(BB).GetValue(param).ToString() == KK; });
            }
            return recipes;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Recipe> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        /*private StreamReader Reader;
        private StreamWriter Writer;

        public FileHandler(string filePathRead, string filePathWrite)
        {
            Reader = new StreamReader(filePathRead);
            Writer = new StreamWriter(filePathWrite);
        }

        public string ReadFromFile()
        {
            string currentText = Reader.ReadToEnd();
            return currentText;
        }
        public void WrightToFile(string textToWritight)
        {
            Writer.Write(textToWritight);
            Writer.Flush();
            Console.WriteLine("text wrote");
        }*/
        


        static void Main(string[] args)
        {
            RecipeBook book = new RecipeBook()
            {
                recipes = new List<Recipe>() {
                    new Recipe() {
                        Name = "borch",
                        cuisine = Сuisine.Ukranian,
                        Ingridients = new Dictionary <string, (int,int)>(),
                        Steps = new List<string>(),
                        Time = 2,
                        type1 = Type1.Soop

                    },
                    new Recipe() {
                        Name = "borch1",
                        cuisine = Сuisine.Ukranian,
                        Ingridients = new Dictionary <string, (int,int)>(),
                        Steps = new List<string>(),
                        Time = 2,
                        type1 = Type1.Soop

                    },
                }
            };
            var elem = book.FindRecepe();
            foreach (var item in elem)
            {
                Console.WriteLine(item.Name);
            }            
        }
    }
}
