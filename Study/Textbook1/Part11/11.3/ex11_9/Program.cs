using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using static UriExtension;

static class UriExtension
{
    public static string TextFromUrl(this Uri uri)
    {
        return "UriExtension: " + uri.ToString();
    }
}

namespace ex11_9
{
        
    class Program
    {
        public static string TextFromUrl(Uri uri)
        {
            return "Program: " + uri.ToString();
        }

        static void Main(string[] args)
        {
            Uri uri = new Uri("http://www.naver.com");
            string txt = TextFromUrl(uri);
        }
    }
}
