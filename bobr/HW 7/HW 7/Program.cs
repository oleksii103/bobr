using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8
{
    internal class Program
    {

        class EnglishFrenchDictionary
        {
            private Dictionary<string, List<string>> dictionary;

            public EnglishFrenchDictionary()
            {
                dictionary = new Dictionary<string, List<string>>();
            }

            public void AddWord(string englishWord, List<string> frenchTranslations)
            {
                if (!dictionary.ContainsKey(englishWord))
                {
                    dictionary.Add(englishWord, frenchTranslations);
                    Console.WriteLine("Added: " + englishWord + " -> " + string.Join(", ", frenchTranslations));
                }
                else
                {
                    Console.WriteLine("Word already exists.");
                }
            }

            public void RemoveWord(string englishWord)
            {
                if (dictionary.ContainsKey(englishWord))
                {
                    dictionary.Remove(englishWord);
                    Console.WriteLine("Removed: " + englishWord);
                }
                else
                {
                    Console.WriteLine("Word not found.");
                }
            }

            public void RemoveTranslation(string englishWord, string frenchTranslation)
            {
                if (dictionary.ContainsKey(englishWord))
                {
                    if (dictionary[englishWord].Contains(frenchTranslation))
                    {
                        dictionary[englishWord].Remove(frenchTranslation);
                        Console.WriteLine("Removed translation: " + frenchTranslation + " for " + englishWord);

                        if (dictionary[englishWord].Count == 0)
                        {
                            dictionary.Remove(englishWord);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Translation not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Word not found.");
                }
            }

            public void UpdateWord(string oldEnglishWord, string newEnglishWord)
            {
                if (dictionary.ContainsKey(oldEnglishWord))
                {
                    dictionary.Add(newEnglishWord, dictionary[oldEnglishWord]);
                    dictionary.Remove(oldEnglishWord);
                    Console.WriteLine("Updated word: " + oldEnglishWord + " -> " + newEnglishWord);
                }
                else
                {
                    Console.WriteLine("Word not found.");
                }
            }

            public void UpdateTranslation(string englishWord, string oldTranslation, string newTranslation)
            {
                if (dictionary.ContainsKey(englishWord))
                {
                    int index = dictionary[englishWord].IndexOf(oldTranslation);
                    if (index != -1)
                    {
                        dictionary[englishWord][index] = newTranslation;
                        Console.WriteLine("Updated translation: " + oldTranslation + " -> " + newTranslation);
                    }
                    else
                    {
                        Console.WriteLine("Translation not found.");
                    }
                }
                else
                {
                    Console.WriteLine("Word not found.");
                }
            }

            public void SearchTranslation(string englishWord)
            {
                if (dictionary.ContainsKey(englishWord))
                {
                    Console.WriteLine(englishWord + " -> " + string.Join(", ", dictionary[englishWord]));
                }
                else
                {
                    Console.WriteLine("Word not found.");
                }
            }

            public void DisplayDictionary()
            {
                Console.WriteLine("\nFull Dictionary:");
                foreach (var entry in dictionary)
                {
                    Console.WriteLine(entry.Key + " -> " + string.Join(", ", entry.Value));
                }
            }

            public void ShowMenu()
            {
                while (true)
                {
                    Console.WriteLine("\nEnglish-French Dictionary Menu:");
                    Console.WriteLine("1. Add Word");
                    Console.WriteLine("2. Remove Word");
                    Console.WriteLine("3. Remove Translation");
                    Console.WriteLine("4. Update Word");
                    Console.WriteLine("5. Update Translation");
                    Console.WriteLine("6. Search Translation");
                    Console.WriteLine("7. Display Full Dictionary");
                    Console.WriteLine("8. Exit");
                    Console.Write("Choose an option: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter English word: ");
                            string eng = Console.ReadLine();
                            Console.Write("Enter French translations (comma separated): ");
                            List<string> translations = new List<string>(Console.ReadLine().Split(','));
                            AddWord(eng, translations);
                            break;
                        case "2":
                            Console.Write("Enter English word to remove: ");
                            RemoveWord(Console.ReadLine());
                            break;
                        case "3":
                            Console.Write("Enter English word: ");
                            string word = Console.ReadLine();
                            Console.Write("Enter French translation to remove: ");
                            RemoveTranslation(word, Console.ReadLine());
                            break;
                        case "4":
                            Console.Write("Enter existing English word: ");
                            string oldWord = Console.ReadLine();
                            Console.Write("Enter new English word: ");
                            UpdateWord(oldWord, Console.ReadLine());
                            break;
                        case "5":
                            Console.Write("Enter English word: ");
                            string eWord = Console.ReadLine();
                            Console.Write("Enter old French translation: ");
                            string oldTrans = Console.ReadLine();
                            Console.Write("Enter new French translation: ");
                            UpdateTranslation(eWord, oldTrans, Console.ReadLine());
                            break;
                        case "6":
                            Console.Write("Enter English word to search: ");
                            SearchTranslation(Console.ReadLine());
                            break;
                        case "7":
                            DisplayDictionary();
                            break;
                        case "8":
                            return;
                        default:
                            Console.WriteLine("Invalid choice, try again.");
                            break;
                    }
                }
            }

            public static void Main()
            {
                EnglishFrenchDictionary dict = new EnglishFrenchDictionary();
                dict.ShowMenu();
            }
        }
    }
}
