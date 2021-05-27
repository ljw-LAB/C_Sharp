using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ex6_39
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ipAddr = IPAddress.Parse("202.179.177.21");
            Console.WriteLine(ipAddr);

            IPAddress ipAddr2 = new IPAddress(new byte[] {202, 179, 177, 21});
            Console.WriteLine(ipAddr2);

            IPAddress ipAddr3 = IPAddress.Parse("2001:0000:85a3:0042:1000:8a2e:0370:7334");
            Console.WriteLine(ipAddr3);

            IPAddress ipAddr4 = IPAddress.Parse("2001::7334");
            Console.WriteLine(ipAddr4);

        }
    }
}
