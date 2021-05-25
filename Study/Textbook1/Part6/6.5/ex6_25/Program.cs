using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex6_25
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(string txt in Directory.GetLogicalDrives())
            {
                Console.WriteLine(txt);
            }
            //////////////////////////
            Console.WriteLine();
            string targetPath = @"C:\Windows\Microsoft.NET\Framework";
            foreach(string txt in Directory.GetFiles(targetPath))
            {
                Console.WriteLine(txt);
            }
            /////////////////////////////
            Console.WriteLine();

            string targetPath1 = @"C:\Windows\Microsoft.NET\Framework";
            foreach(string txt in Directory.GetDirectories(targetPath1))
            {
                Console.WriteLine(txt);
            }
            /////////////////////////////
            Console.WriteLine();
            
            string targetPath2 = @"C:\Windows\Microsoft.NET\Framework";
            foreach(string txt in Directory.GetFiles(targetPath2, "*.exe", SearchOption.AllDirectories))
            {
                Console.WriteLine(txt);
            }
        }
    }
}
