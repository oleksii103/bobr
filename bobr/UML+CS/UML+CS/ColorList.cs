using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UML_Forms;

namespace UML_CS
{
    internal class ColorList
    {
        List<ColorData> colorList = new List<ColorData>();
        public void AddColor(ColorData a)
        {
            colorList.Add(a);
        }
        public void DeleteColor(int b)
        {
            colorList.RemoveAt(b);
        }
        public List<ColorData> GetterList()
        {
            return colorList;
        }
    }
}
