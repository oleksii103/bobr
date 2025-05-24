using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Properties
{
    internal class MusicManager
    {
        static List<string> musicList = new List<string>();
        static string currentMusic;
        static List<string> musicCopy = new List<string>();

        public static string PickRandomMusic()
        {
            Random rand = new Random();
            currentMusic = musicCopy[rand.Next(musicList.Count)];

            musicCopy.Remove(currentMusic);
            return currentMusic;
        }

        public static void LoadMusic(string path)
        {
            musicList = Directory.GetFiles(path).ToList();
            musicCopy = musicList;
        }

        public static bool CheckAnswer(string answer)
        {
            string nameOfMusic = currentMusic.Substring(currentMusic.LastIndexOf("\\"));
            if (nameOfMusic.Substring(0, nameOfMusic.LastIndexOf(",")) == answer) 
            {
                return true;
            }
            else { return false; }
        }

    }
}
