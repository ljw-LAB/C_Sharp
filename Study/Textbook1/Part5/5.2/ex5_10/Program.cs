using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ex5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = ConfigurationSettings.AppSettings["AdminEmailAddress"];
            //string txt = System.Configuration.ConfigurationSettings.AppSettings["AdminEmailAddress"];
            Console.WriteLine(txt);

            txt = ConfigurationSettings.AppSettings["Delay"];
            int delay =int.Parse(txt);
            Console.WriteLine(delay);
        }
    }
}
