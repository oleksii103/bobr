using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace exam
{
    class LanguageDictionary
    {
        public string Name { get; private set; }
        public Dictionary<string, List<string>> Words { get; private set; }
        public string DirectoryPath => "DictionaryStorage";
       
        public string FilePath => @"D:\It Step Academy\c#\bobr\exam\exam\Dictionary.txt";

        public LanguageDictionary(string name)
        {
            Name = name;
            Words = new Dictionary<string, List<string>>();

            Console.WriteLine($"File path: {FilePath}");

            
            string directory = Path.GetDirectoryName(FilePath);
            if (!Directory.Exists(directory))
            {
                Console.WriteLine($"Directory {directory} does not exist. Creating directory...");
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(FilePath))
            {
                Console.WriteLine("File does not exist. Creating new file...");
                SaveToFile();
            }
            else
            {
                Console.WriteLine("File exists. Loading data...");
                LoadFromFile();
            }
        }

        public void AddWord(string word, List<string> translations)
        {
            if (!Words.ContainsKey(word))
            {
                Words[word] = translations;
            }
            else
            {
                Words[word].AddRange(translations.Where(t => !Words[word].Contains(t)));
            }
            SaveToFile();
        }

        public void UpdateWord(string oldWord, string newWord)
        {
            if (Words.ContainsKey(oldWord))
            {
                Words[newWord] = Words[oldWord];
                Words.Remove(oldWord);
                SaveToFile();
            }
        }

        public void UpdateTranslation(string word, string oldTranslation, string newTranslation)
        {
            if (Words.ContainsKey(word))
            {
                int index = Words[word].IndexOf(oldTranslation);
                if (index != -1)
                {
                    Words[word][index] = newTranslation;
                    SaveToFile();
                }
            }
        }

        public void RemoveTranslation(string word, string translation)
        {
            if (Words.ContainsKey(word))
            {
                if (Words[word].Count > 1)
                {
                    Words[word].Remove(translation);
                }
                else
                {
                    Console.WriteLine("Cannot remove the only translation. Remove the word instead.");
                }
                SaveToFile();
            }
        }

        public void RemoveWord(string word)
        {
            if (Words.ContainsKey(word))
            {
                Words.Remove(word);
                SaveToFile();
            }
        }

        public void Search(string word)
        {
            if (Words.ContainsKey(word))
            {
                Console.WriteLine($"{word} -> {string.Join(", ", Words[word])}");
            }
            else
            {
                Console.WriteLine("Word not found.");
            }
        }

        public void ExportWord(string word)
        {
            if (Words.ContainsKey(word))
            {
                string exportDirectory = "Export";
                Directory.CreateDirectory(exportDirectory);
                string path = Path.Combine(exportDirectory, $"{word}_translation.txt");
                File.WriteAllText(path, $"{word}: {string.Join(", ", Words[word])}");
                Console.WriteLine($"Exported to {path}");
            }
        }

        private void LoadFromFile()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    var lines = File.ReadAllLines(FilePath);
                    string currentLanguage = null;

                    foreach (var line in lines)
                    {
                        if (line.StartsWith("Language: "))
                        {
                            currentLanguage = line.Substring("Language: ".Length);
                            Words = new Dictionary<string, List<string>>();
                        }
                        else if (!string.IsNullOrEmpty(line) && currentLanguage != null)
                        {
                            var parts = line.Split(':');
                            if (parts.Length == 2)
                            {
                                var word = parts[0].Trim();
                                var translations = parts[1].Split(',').Select(t => t.Trim()).ToList();
                                Words[word] = translations;
                            }
                        }
                    }

                    Console.WriteLine("Data loaded successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading file: {ex.Message}");
            }
        }

        private void SaveToFile()
        {
            try
            {
                using (var writer = new StreamWriter(FilePath, true)) 
                {
                    writer.WriteLine($"Language: {Name}");
                    foreach (var word in Words)
                    {
                        writer.WriteLine($"{word.Key}:{string.Join(",", word.Value)}");
                    }
                }
                Console.WriteLine($"Dictionary saved successfully to {FilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving dictionary: {ex.Message}");
            }
        }

        public void Display()
        {
            foreach (var entry in Words)
            {
                Console.WriteLine($"{entry.Key} -> {string.Join(", ", entry.Value)}");
            }
        }
    }
}

