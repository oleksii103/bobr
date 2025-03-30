using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twix
{
    public enum Prioritys
    {
        Low,
        Medium,
        High
    }
    public class Task
    {
        public int Id { get; set; }
        public string BodyName { get; set; }
        public string Description {  get; set; }
        public DateTime DeadLine { get; set; }
        public bool Status { get; set; }
       
        public Prioritys Priority { get; set; }
        public void CompleteTask()
        {
            Status = true;
        }

        public override string ToString()
        {
            return $"{Id}, {BodyName}, {Description}, {DeadLine}, {Status}, {Priority.ToString()}";
        }
    }
}
