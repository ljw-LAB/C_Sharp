using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.Net;
using System.Net.Sockets;

namespace ex6_42_client
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(500);
            Thread clientThread = new Thread(clientFunc);
            clientThread.IsBackground = true;
            clientThread.Start();

            Console.WriteLine("종료하려면 아무 키나 누르세요...");
            Console.ReadLine();
        }

        private static void clientFunc(object obj)
        {
            Socket clntSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            EndPoint serverEP = new IPEndPoint(IPAddress.Loopback, 10200);
            EndPoint senderEP = new IPEndPoint(IPAddress.None, 0);

            int nTimes = 5;
            while(nTimes-- > 0)
            {
                byte[] buf = Encoding.UTF8.GetBytes(DateTime.Now.ToString());
                clntSocket.SendTo(buf, serverEP);

                byte[] recvBytes = new byte[1024];
                int nRecv = clntSocket.ReceiveFrom(recvBytes, ref senderEP);

                string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);

                Console.WriteLine(txt);
                Thread.Sleep(1000);
            }

            clntSocket.Close();
            Console.WriteLine("UDP Client socket : Closed");
        }
        // private static IPAddress GetCurrentIPAddress()
        // {
        //     IPAddress[] addrs = Dns.GetHostEntry(Dns.GetHostName()).AddressList;

        //     foreach(IPAddress ipAddr in addrs)
        //     {
        //         if(ipAddr.AddressFamily == AddressFamily.InterNetwork)
        //         {
        //             return ipAddr;
        //         }
        //     }

        //     return  null;
        // }

    }
}
