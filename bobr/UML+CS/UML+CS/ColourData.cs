using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace UML_Forms
{
    internal class ColorData
    {
        private string hex;
        private Color color;
        private int alpha;
        private int red;
        private int green;
        private int blue;

        public void SetterForAll(int Alpha, int Red, int Green, int Blue)
        {
            this.alpha = Alpha;
            this.red = Red;
            this.green = Green;
            this.blue = Blue;
        }

        public string GetHex()
        {
            return hex;
        }
        public Color GetColor()
        {
            return color;
        }
        public void ConvertColor()
        {
            color = new Color();
            color = Color.FromArgb(alpha, red, green, blue);
        }

        public void ConvertHex()
        {
            hex = "#" + IntToHex(alpha);
            hex += IntToHex(red);
            hex += IntToHex(green);
            hex += IntToHex(blue);
        }

        private string IntToHex(int a)
        {
            int b = a / 16;
            int c = a % 16;
            string result = "";
            switch (b)
            {
                case 10:
                    result = "A";
                    break;
                case 11:
                    result = "B";
                    break;
                case 12:
                    result = "C";
                    break;
                case 13:
                    result = "D";
                    break;
                case 14:
                    result = "E";
                    break;
                case 15:
                    result = "F";
                    break;
                default:
                    result = b.ToString();
                    break;

            }
            switch (c)
            {
                case 10:
                    result += "A";
                    break;
                case 11:
                    result += "B";
                    break;
                case 12:
                    result += "C";
                    break;
                case 13:
                    result += "D";
                    break;
                case 14:
                    result += "E";
                    break;
                case 15:
                    result += "F";
                    break;
                default:
                    result += c.ToString();
                    break;
            }


            return result;
        }

    }
}