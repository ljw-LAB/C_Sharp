using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

using System.Net;
using System.Net.Sockets;

namespace ex6_46
{
    class Program
    {
        static void Main(string[] args)
        {
            using(Socket srvSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                Console.WriteLine("http://localhost:8000으로 방문해보세요");
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 8000);

                srvSocket.Bind(endPoint);
                srvSocket.Listen(10);

                while(true)
                {
                    Socket clntSock = srvSocket.Accept();
                    ThreadPool.QueueUserWorkItem(httpProcessFunc,clntSock);
                }
            }
        }

        private static void httpProcessFunc(object state)
        {
            Socket socket = state as Socket;
            byte[] reqBuf = new byte[4096];
            socket.Receive(reqBuf);

            string header = "HTTP/1.0 200 OK\nContent-Type: text/html; charset=UTF-8\r\n\r\n";
            string body = "<html><body><mark>테스트 HTML</mark> 웹 페이지입니다. </body></html>";

            byte[] respBuf = Encoding.UTF8.GetBytes(header + body);
            socket.Send(respBuf);
            socket.Close();
        }
    }
}
