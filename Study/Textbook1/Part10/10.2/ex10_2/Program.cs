using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            AwaitRead();
            Console.ReadLine();
        }

        private static async void AwaitRead()
        {
            using(FileStream fs = new FileStream(@"C:\windows\system32\drivers\etc\HOSTS", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                byte[] buf = new byte[fs.Length];
                await fs.ReadAsync(buf, 0, buf.Length);

                string txt = Encoding.UTF8.GetString(buf);
                Console.WriteLine(txt);
            }
        }
    }
}
