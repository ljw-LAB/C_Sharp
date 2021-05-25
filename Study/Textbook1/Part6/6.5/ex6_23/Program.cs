using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex6_23
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.Copy("test.log", "test.dat");
            File.Copy("test.log", "test.dat", true);
            //File.Move("test.log", "test.dat");
            //File.Move("test.log", "c:\\temp\\test.dat");

            // string target = "c:\\temp\\test.dat";
            // if(File.Exists(target) == true)
            // {
            //     File.Delete(target);
            // }
            // File.Move("test.log", target);
        }
    }
}
