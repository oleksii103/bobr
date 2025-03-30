using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Debilyako
{
    public interface ISub
    {
        void Upgrade(string VideoName);

    }
    public class Subber : ISub
    {
        public void Upgrade(string VideoName)
        {
            Console.WriteLine($"new video {VideoName} was published on the channel");
        }
    }
    public class Chanel
    {
        public string Name { get; set; }
        public List<ISub> Subs { get; set; } = new List<ISub>();
        public List<string> Videos { get; set; }
        private static Random random = new Random();

        public Chanel(string name, int sub = 0)
        {
            Name = name;
            Videos = new List<string>();
        }
        public void AddVideo(string title)
        {
            Videos.Add(title);
            for (int i = 0; i < Subs.Count;  i++)
            {
                Subs[i].Upgrade(title);
            }
        }
        public void AddSub(ISub sub)
        {
            Subs.Add(sub);
        }
        public void RemoveSub(ISub sub)
        {
            Subs.Remove(sub);
        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Chanel ytChanel = new Chanel("Boingo_Yt", 120);   
            Subber subber = new Subber();
            Subber subber1 = new Subber();
            ytChanel.AddSub(subber1);
            ytChanel.AddSub(subber);
            ytChanel.AddVideo("why putler sucks");
        }
    }
}