using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex10_7
{
    class Program
    {
        public delegate string ReadAllTextDelegate(string path);
        static void Main(string[] args)
        {
            string filePath = @"c:\windows\system32\drivers\etc\HOSTS";

            ReadAllTextDelegate func = File.ReadAllText;
            func.BeginInvoke(filePath, actionCompleted, func);

            Console.ReadLine();
        }
        
        static void actionCompleted(IAsyncResult ar)
        {
            ReadAllTextDelegate func = ar.AsyncState as ReadAllTextDelegate;
            string fileText = func.EndInvoke(ar);
            Console.WriteLine(fileText);
        }
    }
}
