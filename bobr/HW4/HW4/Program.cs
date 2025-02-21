using System;

namespace HW4
{
    internal class Program
    {
        static void DrawSquare(int size, char symbol)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
        }

        class Website
        {
            private string name;
            private string url;
            private string description;
            private string ipAddress;

            public Website(string name, string url, string description, string ipAddress)
            {
                this.name = name;
                this.url = url;
                this.description = description;
                this.ipAddress = ipAddress;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Website Name: {name}");
                Console.WriteLine($"Website URL: {url}");
                Console.WriteLine($"Website Description: {description}");
                Console.WriteLine($"Website IP Address: {ipAddress}");
            }
        }

        class Reservoir
        {
            private double volume;
            private string material;
            private bool isFilled;
            private double currentLevel;

            public Reservoir(double volume, string material, bool isFilled)
            {
                this.volume = volume;
                this.material = material;
                this.isFilled = isFilled;
                this.currentLevel = isFilled ? volume : 0;
            }

            public void Fill(double amount)
            {
                if (currentLevel + amount > volume)
                {
                    Console.WriteLine("Overflow warning! Filling up to maximum capacity.");
                    currentLevel = volume;
                }
                else
                {
                    currentLevel += amount;
                }
                isFilled = currentLevel == volume;
            }

            public void Empty(double amount)
            {
                if (currentLevel - amount < 0)
                {
                    Console.WriteLine("Underflow warning! Emptying completely.");
                    currentLevel = 0;
                }
                else
                {
                    currentLevel -= amount;
                }
                isFilled = currentLevel == volume;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Reservoir Volume: {volume} liters");
                Console.WriteLine($"Material: {material}");
                Console.WriteLine($"Current Level: {currentLevel} liters");
                Console.WriteLine($"Status: {(isFilled ? "Filled" : "Not Filled")}");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select a task:");
                Console.WriteLine("1 - Draw a square");
                Console.WriteLine("2 - Display website info");
                Console.WriteLine("3 - Reservoir operations");
                Console.WriteLine("4 - Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter size: ");
                        int size = int.Parse(Console.ReadLine());
                        Console.Write("Enter symbol: ");
                        char symbol = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        DrawSquare(size, symbol);
                        break;

                    case "2":
                        Website site = new Website("Google", "https://www.google.com", "Search Engine", "8.8.8.8");
                        site.DisplayInfo();
                        break;

                    case "3":
                        Reservoir tank = new Reservoir(100, "Steel", false);
                        tank.DisplayInfo();
                        tank.Fill(50);
                        tank.DisplayInfo();
                        tank.Fill(60);
                        tank.DisplayInfo();
                        tank.Empty(30);
                        tank.DisplayInfo();
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}