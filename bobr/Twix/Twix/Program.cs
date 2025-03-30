using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Twix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManegerTask taskList = new ManegerTask();
            using (StreamReader Frodo = new StreamReader("Koko.json"))
            {
                string Json = Frodo.ReadToEnd();
                taskList = JsonConvert.DeserializeObject<ManegerTask>(Json);
            }
                while (true)
                {
              
                    Console.WriteLine(taskList);

                    Console.WriteLine("menu\n  1 - Add new task\n 2 - Upgrade task\n 3 - delete task\n 4 - search task by Id");
                    int x = int.Parse(Console.ReadLine());

                    switch (x)
                    {
                        case 1:
                            Console.WriteLine("enter task Id: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter worker name; ");
                            string b = Console.ReadLine();
                            Console.WriteLine("Enter deskription for task: ");
                            string c = Console.ReadLine();
                            Console.WriteLine("enter task deadline: ");
                            DateTime d = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("enter task status: ");
                            bool e = DateTime.TryParse(Console.ReadLine(), out d);
                            Console.WriteLine("enter priority (High, Medium, Low): ");
                            Enum.TryParse(Console.ReadLine(), out Prioritys myStatus);

                            Twix.Task y = new Twix.Task() { Id = a, BodyName = b, DeadLine = d, Description = c, Priority = myStatus, Status = e };
                            taskList.NewTask(y);
                            break;
                        case 2:
                            Console.WriteLine("enter task Id to upgrade: ");
                            int A = int.Parse(Console.ReadLine());
                            Console.WriteLine("enter worker name; ");
                            string B = Console.ReadLine();
                            Console.WriteLine("Enter deskription for task: ");
                            string C = Console.ReadLine();
                            Console.WriteLine("enter task deadline: ");
                            DateTime D = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("enter task status: ");
                            bool E = DateTime.TryParse(Console.ReadLine(), out d);
                            Console.WriteLine("enter priority (High, Medium, Low): ");
                            Enum.TryParse(Console.ReadLine(), out Prioritys MyStatus);

                            Twix.Task Y = new Twix.Task() { Id = A, BodyName = B, DeadLine = D, Description = C, Priority = MyStatus, Status = E };
                            taskList.UpdateTask(A, Y);
                            break;
                        case 3:
                            Console.WriteLine("enter deletebel task Id: ");
                            int N = int.Parse(Console.ReadLine());
                            taskList.DeleteTask(N);
                            break;
                        case 4:
                            Console.WriteLine("enter task Id to search: ");
                            int K = int.Parse(Console.ReadLine());
                            Twix.Task g = taskList.SearchTask(K);
                            Console.WriteLine(g.ToString());
                            break;
                    }
                    string json = JsonConvert.SerializeObject(taskList, Newtonsoft.Json.Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
                    using (StreamWriter Bilbo = new StreamWriter("Koko.json"))
                    {
                        Bilbo.WriteLine(json);
                    }
            }

        }

    }
}
