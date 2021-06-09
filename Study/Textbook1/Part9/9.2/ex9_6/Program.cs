using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;

namespace ex9_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var scriptEngine = Python.CreateEngine();
            string code = @"print 'Hello Python'"; //탭사용 시 주의, 
            //https://m.blog.naver.com/PostView.naver?isHttpsRedirect=true&blogId=doublebee1&logNo=221137823869 참조
            scriptEngine.Execute(code);
        }
    }
}

