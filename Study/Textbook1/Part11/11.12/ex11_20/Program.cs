using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11_20
{
    class Program
    {
        static Task NullTask()
        {
            Console.WriteLine("NullTask");
            return null;
        }
        static void Main(string[] args)
        {
            Task.Run(NullTask);
        }
    }
}
