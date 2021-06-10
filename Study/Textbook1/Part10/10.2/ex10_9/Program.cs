using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;

namespace ex10_9
{
    class Program
    {        
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            
            Thread t3 = new Thread((result) =>
            {
                Thread.Sleep(3000);
                dict.Add("t3Result", 3);

            });

            Thread t5 = new Thread((result) =>
            {
                Thread.Sleep(5000);
                dict.Add("t5Result", 5);

            });

            t3.Start(dict);
            t5.Start(dict);

            t3.Join();
            t5.Join();

            Console.WriteLine(dict["t3Result"] + dict["t5Result"]);
        }
    }
}
