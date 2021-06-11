using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using static System.Console;
using static UriExtension;

static class UriExtension
{
    public static string TextFromUrl(this Uri uri)
    {
        WebClient wc = new WebClient();
        wc.Encoding = Encoding.UTF8;
        return wc.DownloadString(uri);
    }
}

namespace ex11_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri uri = new Uri("http://www.naver.com");
            WriteLine(uri.TextFromUrl());
            //WriteLine(TextFromUrl(uri)); 컴파일 에러
            WriteLine(UriExtension.TextFromUrl(uri));
        }
    }
}
