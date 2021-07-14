using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_3
{
    class Program
    {
        public string Message
        {
            get{ return Console.ReadLine(); }
            set{ Console.WriteLine(value); }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Message = obj.Message;
        }
    }
}
