using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.Net;
using System.Net.Sockets;

namespace ex6_42
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread serverThread = new Thread(serverFunc);
            serverThread.IsBackground = true;
            serverThread.Start();

            Console.WriteLine("종료하려면 아무 키나 누르세요...");
            Console.ReadLine();
        
        }

        // private static void serverFunc(object obj)
        // {
        //     Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        //     IPAddress ipAddress = GetCurrentIPAddress();
            
        //     if(ipAddress == null)
        //     {
        //         Console.WriteLine("IPv4용 랜 카드가 없습니다. ");
        //         return;
        //     }
        //     IPEndPoint endPoint = new IPEndPoint(ipAddress, 10200);
        //     socket.Bind(endPoint);
        // }

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

        private static void serverFunc(object obj)
        {
            using ( Socket srvsocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
            {
                IPAddress ipAddress = IPAddress.Parse("0.0.0.0");
                IPEndPoint endPoint = new IPEndPoint(ipAddress, 10200);

                srvsocket.Bind(endPoint);
                byte[] recvBytes = new byte[1024];
                EndPoint clientEP = new IPEndPoint(IPAddress.None, 0);

                while(true)
                {
                    int nRecv = srvsocket.ReceiveFrom(recvBytes, ref clientEP);
                    string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);

                    byte[] sendBytes = Encoding.UTF8.GetBytes("Hello: " + txt);
                    srvsocket.SendTo(sendBytes, clientEP);
                }
            }
        }

    }
}
