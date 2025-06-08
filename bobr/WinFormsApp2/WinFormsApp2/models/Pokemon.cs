using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.models
{
    public class Pokemon
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Level { get; set; }

        public int Hp { get; set; }

        public int Exp { get; set; }

        public string Type { get; set; } = string.Empty;

        public string? SecondType { get; set; }
    }

}
