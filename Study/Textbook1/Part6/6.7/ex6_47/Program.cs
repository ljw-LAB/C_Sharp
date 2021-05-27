using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

using System.Net;
using System.Net.Sockets;

using System.IO;

namespace ex6_47
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     // HttpWebRequest 타입은 내부적으로 TCP 소켓을 생성하고,
        //     HttpWebRequest req = WebRequest.Create("http://www.naver.com") as HttpWebRequest;

        //     // GetResponse 호출 단계에서 지정된 웹 서버로 HTTP 요청을 보내고, 응답을 받는다.
        //     HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
        //     // 응답 내용을 담고 있는 Stream으로부터 문자열을 반환해서 출력한다.

        //     using (StreamReader sr = new StreamReader(resp.GetResponseStream()))
        //     {
        //         string responseText = sr.ReadToEnd();
        //         Console.WriteLine(responseText);
        //         File.WriteAllText("naverpage.html", responseText);
        //     }
        // }

        static void Main(string[] args)
        {
            // WebClient 타입은 내부적으로 HttpWebRequest 개체를 사용해 통신
            WebClient wc = new WebClient();
            string responseText = wc.DownloadString("http://www.naver.com");

            Console.WriteLine(responseText);
            File.WriteAllText("naverpage.html", responseText);

        }
    }
}
