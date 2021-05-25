using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex6_24
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = new string('c', 20);
            File.WriteAllText("test.log", text);

            string clone = File.ReadAllText("test.log");
            Console.WriteLine(clone); 

            //////////////////////////////

            // FileInfo source = new FileInfo("test.log");
            // FileInfo target = new FileInfo("c:\\temp\\test.dat");

            // if(target.Exists == true)
            // {
            //     target.Delete();
            // }

            // source.MoveTo(target.FullName);
        }
    }
}
