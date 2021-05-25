using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex6_19
{
    
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("test.log", FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.WriteLine("Hello world");
                sw.WriteLine("Anderson");
                sw.Write(32000);
                sw.Flush();
            }
        }
    }
}
