using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;

namespace ex9_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var scriptEngine = Python.CreateEngine();
            var scriptScope = scriptEngine.CreateScope();

            string code = @"def AddFunc(a, b): 
                          print 'AddFunc called'
                          return (a + b)
                          ";
            scriptEngine.Execute(code, scriptScope);

            dynamic addFunc = scriptScope.GetVariable("AddFunc");
            int nResult = addFunc(5, 10);

            Console.WriteLine(nResult);
        }
    }
}
