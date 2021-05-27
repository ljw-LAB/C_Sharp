using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

using System.Net;
using System.Net.Sockets;

namespace ex6_43_client
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread clientThread = new Thread(clientFunc);
            clientThread.IsBackground = true;
            clientThread.Start();

            Console.WriteLine("종료하려면 아무 키나 누르세요...");
            Console.ReadLine();
        }

        private static void clientFunc(object obj)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            EndPoint serverEP = new IPEndPoint(IPAddress.Loopback, 11200);
            socket.Connect(serverEP);

            byte[] buf = Encoding.UTF8.GetBytes(DateTime.Now.ToString());
            socket.Send(buf);

            byte[] recvBytes = new byte[1024];
            int nRecv = socket.Receive(recvBytes);

            string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);
            Console.WriteLine(txt);
            socket.Close();

            Console.WriteLine("TCP Client socket: Closed");
        }


    }
}
