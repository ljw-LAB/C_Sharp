using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.Net;
using System.Net.Sockets;

namespace ex6_43_server
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread serverThread = new Thread(serverFunc);
            serverThread.IsBackground = true;
            serverThread.Start();
            Thread.Sleep(500);

            Console.WriteLine("종료하려면 아무 키나 누르세요...");
            Console.ReadLine();
        }

        private static void serverFunc(object obj)
        {
            using ( Socket srvsocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 11200);

                srvsocket.Bind(endPoint);
                srvsocket.Listen(10);

                while(true)
                {
                    Socket clntSocket = srvsocket.Accept();

                    byte[] recvBytes = new byte[1024];

                    int nRecv = clntSocket.Receive(recvBytes);
                    string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);

                    byte[] sendBytes = Encoding.UTF8.GetBytes("Hello: " + txt);
                    clntSocket.Send(sendBytes);
                    clntSocket.Close();
                }
            }
        }

    }
}
