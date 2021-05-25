using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex6_21
{
    class Program
    {
        static void Main(string[] args)
        {

            using (FileStream fs = new FileStream("test.log", FileMode.Append))
            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.WriteLine("Hello world");
                Console.ReadLine();
            }

            //using (FileStream fs = new FileStream("test.log", FileMode.Append, FileAccess.Write, FileShare.None))
            //using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            //{
            ///   sw.WriteLine("Hello world");
            //    Console.ReadLine();
            //}
        }
    }
}
