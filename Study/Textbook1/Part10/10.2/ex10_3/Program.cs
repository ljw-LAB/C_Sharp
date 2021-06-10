using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ex10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();
            string text = wc.DownloadString("http://www.microsoft.com");
            Console.WriteLine(text);
        }
    }
}
