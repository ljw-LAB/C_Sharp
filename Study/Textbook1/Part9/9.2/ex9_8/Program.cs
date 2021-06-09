using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using IronPython.Hosting;

namespace ex9_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var scriptEngine = Python.CreateEngine();
            var scriptScope = scriptEngine.CreateScope();

            List<string> list = new List<string>();
            scriptScope.SetVariable("myList", list);

            string code = @"
myList.Add('my') 
myList.Add('python')
";//띄어쓰기 안됨 에러남, 엔터로 구성하기

  //            string code = @"
  //myList.Add('my')
  //myList.Add('python')
  //";
            scriptEngine.Execute(code, scriptScope);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}