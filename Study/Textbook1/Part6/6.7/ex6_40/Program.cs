using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ex6_40
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ipAddr = IPAddress.Parse("192.168.1.10");
            IPEndPoint endpoint = new IPEndPoint(ipAddr, 9000);
            Console.WriteLine(endpoint);
        }
    }
}
