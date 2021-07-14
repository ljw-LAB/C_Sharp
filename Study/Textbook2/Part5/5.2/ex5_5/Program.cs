using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_5
{
    class Color
    {
        private string[] color = new string[5];
        public string this[int index]
        {
            get{return color[index];}
            set{color[index] = value;}

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Color c = new Color();
            c[0] = "WHITE";
            c[1] = "RED";
            c[2] = "YELLO";
            c[3] = "BLUE";
            c[4] = "BLACK";
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Color is " + c[i]);
            }

        }
    }
}
