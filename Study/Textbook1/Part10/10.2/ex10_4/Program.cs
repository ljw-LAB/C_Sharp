using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ex10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();
            wc.DownloadStringCompleted += wc_DownloadStringCompleted;
            wc.DownloadStringAsync(new Uri("http://www.microsoft.com"));
            Console.ReadLine();
        }

        static void wc_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            Console.WriteLine(e.Result);
        }
    }
}
