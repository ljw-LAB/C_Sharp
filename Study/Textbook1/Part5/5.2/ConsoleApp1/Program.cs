using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LogWriter logwriter = new LogWriter();
            logwriter.Write("start");

            string txt = ConfigurationSettings.AppSettings["AdminEmailAddress"];
            Console.WriteLine(txt);

            //txt = ConfigurationSettings.AppSettings["Delay"];
            //int delay =int.Parse(txt);
            //Console.WriteLine(delay);
        }
    }
}
