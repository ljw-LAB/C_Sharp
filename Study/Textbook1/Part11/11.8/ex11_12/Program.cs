using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex11_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"c:\temp\test.txt";
            try
            {
                string txt = File.ReadAllText(filePath);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
