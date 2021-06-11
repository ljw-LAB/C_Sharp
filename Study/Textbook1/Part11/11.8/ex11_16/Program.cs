using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex11_16
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new FileNotFoundException("test.txt");
            }
            catch(FileNotFoundException e) when (Log(e))
            {
                Console.WriteLine("1");
            }
            catch(FileNotFoundException e) when (Log(e))
            {
                Console.WriteLine("2");
            }
            catch(FileNotFoundException e) 
            {
                Console.WriteLine("3");
            }
        }

        private static bool Log(Exception e)

        {
            return false;
        }
    }
}
