using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_4
{
    class Program
    {
        private string text = "Dept. of Comuputer Engineering";
        private bool isModified = false;
        public string Text
        {
            get{return text;}
            set{text = value; isModified = true;}
        }

        public void PrintStatus()
        {
            Console.WriteLine("text is \"" + text + "\", and "+(isModified ? "is" : "not") + " modified." );
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.PrintStatus();
            obj.Text = "Programming Language Lab";
            obj.PrintStatus();
        }
    }
}
