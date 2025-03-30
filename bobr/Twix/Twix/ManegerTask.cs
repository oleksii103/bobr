using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twix
{
    internal class ManegerTask
    {
        public string Name {  get; set; }
        public List<Twix.Task> TaskList { get; set; }

        public void NewTask (Twix.Task task)
        {
            TaskList.Add(task);
        }

        public void UpdateTask (int Id, Twix.Task task)
        {
           var oldTask = TaskList.FirstOrDefault(x => {
                if (x.Id == Id) { return true; }
                else return false; });
            TaskList.Remove(oldTask);
            TaskList.Add(task);
        }
       
        public void DeleteTask (int Id) 
        {
            var oldTask = TaskList.FirstOrDefault(x => {
                if (x.Id == Id) { return true; }
                else return false;
            });
            TaskList.Remove(oldTask);
        }

        public Twix.Task SearchTask (int Id)
        {
            var oldTask = TaskList.FirstOrDefault(x => {
                if (x.Id == Id) { return true; }
                else return false;
            });
            return oldTask;
        }
        public override string ToString()
        {
            string Neym = Name + "\n";
            for (int i = 0; i < TaskList.Count; i++)
            {
                Neym += TaskList[i].ToString() + "\n";
            }
            return Neym;

        }

    }
}
