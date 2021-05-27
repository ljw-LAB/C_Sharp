using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ex6_41
{
    class Program
    {
        static void Main(string[] args)
        {
            IPHostEntry entry = Dns.GetHostEntry("www.microsoft.com");
            foreach(IPAddress ipAddress in entry.AddressList)
            {
                Console.WriteLine(ipAddress);
            }
            Console.WriteLine();
            /////////////////
            string myComputer = Dns.GetHostName();
            Console.WriteLine("컴퓨터 이름 : " + myComputer);
            IPHostEntry entry1 = Dns.GetHostEntry(myComputer);
            foreach(IPAddress ipAddress1 in entry1.AddressList)
            {
                Console.WriteLine(ipAddress1.AddressFamily + ": " + ipAddress1);
            }
        }
    }
}
