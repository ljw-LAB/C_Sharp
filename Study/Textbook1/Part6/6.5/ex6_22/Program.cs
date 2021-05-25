using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex6_22
{
    class Program
    {
        static void Main(string[] args)
        {
            // using(FileStream fs = new FileStream(Environment.CurrentDirectory + @"\test.log", FileMode.Create ))
            // {

            // }
            
            Environment.CurrentDirectory = "c:\\temp";
            using (FileStream fs = new FileStream("test.log", FileMode.Create))
            {

            }
        }
    }
}
