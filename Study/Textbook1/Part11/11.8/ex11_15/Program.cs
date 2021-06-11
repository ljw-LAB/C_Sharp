using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex11_15
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new FileNotFoundException("test.txt");
            }
            catch(FileNotFoundException e) when (Process(e)){}
            catch(Exception e) when (Process(e)){}

        }

        private static bool Process(Exception e)
        {
            Console.WriteLine(e.ToString());
            return false;
        }
    }
}
