using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ex13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync();
        }

        // private static async Task MainAsync()
        // {
        //     WebClient wc = new WebClient();
        //     string text = await wc.DownloadStringTaskAsync("http://www.microsoft.com");
        //     Console.WriteLine(text);

        // }

        static async Task MainAsync()
        {
            WebClient wc = new WebClient();
            string text = await wc.DownloadStringTaskAsync("http://www.microsoft.com");
            Console.WriteLine(text);

        }
    }
}
