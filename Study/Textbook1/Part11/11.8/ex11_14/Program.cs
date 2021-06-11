using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex11_14
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
            catch (FileNotFoundException e) when (SwallowWhenTempFile(filePath))
            {
                Console.WriteLine(e.ToString());
            }
        }

        static bool SwallowWhenTempFile(string filePath)
        {
            return filePath.IndexOf("temp") != -1;
        }
    }
}
