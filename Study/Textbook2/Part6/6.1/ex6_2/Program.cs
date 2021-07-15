using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void MultiCastDelegate();

namespace ex6_2
{
    class Schedule
    {
        public void Now()
        {
            Console.WriteLine("Time : " +DateTime.Now.ToString());
        }
        public static void Today()
        {
            Console.WriteLine("Date : " +DateTime.Today.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Schedule obj = new Schedule();
            MultiCastDelegate mcd = new MultiCastDelegate(obj.Now);
            mcd += new MultiCastDelegate(Schedule.Today);
            mcd();
        }
    }
}
