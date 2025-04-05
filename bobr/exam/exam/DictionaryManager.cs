using System;
using System.Collections.Generic;
using System.Linq;

namespace exam
{
    class DictionaryManager
    {
        private Dictionary<string, LanguageDictionary> dictionaries = new Dictionary<string, LanguageDictionary>();

        public void ShowMainMenu()
        {
            while (true)
            {
                Console.WriteLine("\nMAIN MENU:");
                Console.WriteLine("1. Create Dictionary");
                Console.WriteLine("2. Select Dictionary");
                Console.WriteLine("3. Exit");
                Console.Write("Choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateDictionary();
                        break;
                    case "2":
                        SelectDictionary();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private void CreateDictionary()
        {
            Console.Write("Enter dictionary name (e.g., English-Ukrainian): ");
            string name = Console.ReadLine();
            if (!dictionaries.ContainsKey(name))
            {
                dictionaries[name] = new LanguageDictionary(name);
                Console.WriteLine("Dictionary created.");
            }
            else
            {
                Console.WriteLine("Dictionary already exists.");
            }
        }

        private void SelectDictionary()
        {
            Console.WriteLine("Available dictionaries:");
            foreach (var dictName in dictionaries.Keys)
            {
                Console.WriteLine("- " + dictName);
            }

            Console.Write("Enter name to select: ");
            string name = Console.ReadLine();

            if (dictionaries.ContainsKey(name))
            {
                ShowDictionaryMenu(dictionaries[name]);
            }
            else
            {
                Console.WriteLine("Dictionary not found.");
            }
        }

        private void ShowDictionaryMenu(LanguageDictionary dict)
        {
            while (true)
            {
                Console.WriteLine($"\n--- {dict.Name} Dictionary ---");
                Console.WriteLine("1. Add Word");
                Console.WriteLine("2. Update Word");
                Console.WriteLine("3. Update Translation");
                Console.WriteLine("4. Remove Word");
                Console.WriteLine("5. Remove Translation");
                Console.WriteLine("6. Search");
                Console.WriteLine("7. Display Dictionary");
                Console.WriteLine("8. Export Word");
                Console.WriteLine("9. Back to Main Menu");
                Console.Write("Choice: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Word: ");
                        var word = Console.ReadLine();
                        Console.Write("Translations (comma separated): ");
                        var translations = Console.ReadLine().Split(',').ToList();
                        dict.AddWord(word, translations);
                        break;
                    case "2":
                        Console.Write("Old word: ");
                        var oldWord = Console.ReadLine();
                        Console.Write("New word: ");
                        var newWord = Console.ReadLine();
                        dict.UpdateWord(oldWord, newWord);
                        break;
                    case "3":
                        Console.Write("Word: ");
                        var w = Console.ReadLine();
                        Console.Write("Old translation: ");
                        var oldT = Console.ReadLine();
                        Console.Write("New translation: ");
                        var newT = Console.ReadLine();
                        dict.UpdateTranslation(w, oldT, newT);
                        break;
                    case "4":
                        Console.Write("Word to remove: ");
                        dict.RemoveWord(Console.ReadLine());
                        break;
                    case "5":
                        Console.Write("Word: ");
                        var rw = Console.ReadLine();
                        Console.Write("Translation to remove: ");
                        dict.RemoveTranslation(rw, Console.ReadLine());
                        break;
                    case "6":
                        Console.Write("Word to search: ");
                        dict.Search(Console.ReadLine());
                        break;
                    case "7":
                        dict.Display();
                        break;
                    case "8":
                        Console.Write("Word to export: ");
                        dict.ExportWord(Console.ReadLine());
                        break;
                    case "9":
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
