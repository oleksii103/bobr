using System;
using System.Collections.Generic;

namespace SurnameCheckApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Surname Array Checks ===\n");

            Console.Write("Enter surnames separated by commas (e.g., Smith,Walker,Brown): ");
            string input = Console.ReadLine();

            string[] rawParts = input.Split(',');
            List<string> surnamesList = new List<string>();

            foreach (string part in rawParts)
            {
                string cleaned = part.Trim();
                if (cleaned != "")
                {
                    surnamesList.Add(cleaned);
                }
            }

            string[] surnames = surnamesList.ToArray();

            if (surnames.Length == 0)
            {
                Console.WriteLine("The surname array is empty. Exiting program.");
                return;
            }

            Console.WriteLine("\n--- Check Results ---");

            bool allMoreThanThree = true;
            foreach (string s in surnames)
            {
                if (s.Length <= 3)
                {
                    allMoreThanThree = false;
                    break;
                }
            }
            Console.WriteLine("1. All surnames have more than 3 characters: " + (allMoreThanThree ? "Yes" : "No"));

            bool allInRange = true;
            foreach (string s in surnames)
            {
                if (s.Length <= 3 || s.Length >= 10)
                {
                    allInRange = false;
                    break;
                }
            }
            Console.WriteLine("2. All surnames have length between 4 and 9 characters: " + (allInRange ? "Yes" : "No"));

            bool anyStartsWithW = false;
            foreach (string s in surnames)
            {
                if (s.StartsWith("W") || s.StartsWith("w"))
                {
                    anyStartsWithW = true;
                    break;
                }
            }
            Console.WriteLine("3. At least one surname starts with 'W': " + (anyStartsWithW ? "Yes" : "No"));

            bool anyEndsWithY = false;
            foreach (string s in surnames)
            {
                if (s.EndsWith("Y") || s.EndsWith("y"))
                {
                    anyEndsWithY = true;
                    break;
                }
            }
            Console.WriteLine("4. At least one surname ends with 'Y': " + (anyEndsWithY ? "Yes" : "No"));

            bool containsOrange = false;
            foreach (string s in surnames)
            {
                if (s.Equals("Orange", StringComparison.OrdinalIgnoreCase))
                {
                    containsOrange = true;
                    break;
                }
            }
            Console.WriteLine("5. The array contains the surname 'Orange': " + (containsOrange ? "Yes" : "No"));

            string firstLengthSix = null;
            foreach (string s in surnames)
            {
                if (s.Length == 6)
                {
                    firstLengthSix = s;
                    break;
                }
            }
            Console.WriteLine("6. First surname with length 6: " + (firstLengthSix ?? "Not found"));

            string lastLessThan15 = null;
            foreach (string s in surnames)
            {
                if (s.Length < 15)
                {
                    lastLessThan15 = s;
                }
            }
            Console.WriteLine("7. Last surname with length less than 15: " + (lastLessThan15 ?? "Not found"));
            Console.ReadLine();
        }
    }
}
