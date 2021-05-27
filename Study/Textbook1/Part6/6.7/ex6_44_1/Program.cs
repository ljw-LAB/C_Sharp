using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

using System.Net;
using System.Net.Sockets;

namespace ex6_44_1
{
    public class ASyncStateData
    {
        public byte[] Buffer;
        public Socket Socket;
    }
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
            using(Socket srvSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 11200);
                srvSocket.Bind(endPoint);
                srvSocket.Listen(10);
                
                while(true)
                {
                    Socket clntSocket = srvSocket.Accept();
                    ASyncStateData data = new ASyncStateData();
                    data.Buffer = new byte[1024];
                    data.Socket = clntSocket;

                    clntSocket.BeginReceive(data.Buffer, 0, data.Buffer.Length, SocketFlags.None, asyncReceiveCallback, data);
                }
            }
        }

        private static void asyncReceiveCallback(IAsyncResult asyncResult)
        {
            ASyncStateData rcvData = asyncResult.AsyncState as ASyncStateData;
            int nRecv = rcvData.Socket.EndReceive(asyncResult);
            string txt = Encoding.UTF8.GetString(rcvData.Buffer, 0, nRecv);

            byte[] sendBytes = Encoding.UTF8.GetBytes("Hello: " + txt);
            rcvData.Socket.BeginSend(sendBytes, 0, sendBytes.Length, SocketFlags.None, asyncSendCallback, rcvData.Socket);
        }

        private static void asyncSendCallback(IAsyncResult asyncResult)
        {
            Socket socket = asyncResult.AsyncState as Socket;
            socket.EndSend(asyncResult);
            socket.Close();
        }

        // try UDP 예외 처리구문(클라이언트 데이터 수신 불가 관련)
        // {
        //     byte[] recvBytes = new byte[1024];
        //     int nRecv = socket.Receive(recvBytes);            
        //     string txt = Encoding.UTF8.GetString(recvBytes, 0, nRecv);
        //     Console.WriteLine(txt);
        // }
        // catch (System.Exception)
        // {
            
        // }

        // socket.Close();
    }
}
