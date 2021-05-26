using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ex6_37_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(readCompleted);

            Console.ReadLine();
        }

        static void readCompleted(object state)
        {
            using (FileStream fs = new FileStream(@"c:\windows\system32\drivers\etc\HOSTS", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                byte[] buf = new byte[fs.Length];
                fs.Read(buf, 0, buf.Length);

                string txt = Encoding.UTF8.GetString(buf);
                Console.WriteLine(txt);
            }
            
        }
    }
}
