using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now + " : " + now.Kind);

            DateTime utcnow = DateTime.UtcNow;
            Console.WriteLine(now + " : " + utcnow.Kind);

            DateTime worldcup2002 = new DateTime(2002, 5, 31);
            Console.WriteLine(worldcup2002 + ": " + worldcup2002.Kind);

            worldcup2002 = new DateTime(2002, 5, 31, 0, 0, 0, DateTimeKind.Local);
            Console.WriteLine(worldcup2002 + ": " + worldcup2002.Kind);

            DateTime endOfYear = new DateTime(DateTime.Now.Year, 12, 31);
            DateTime now1 = DateTime.Now;

            Console.WriteLine("오늘 날짜 "+now1);
            TimeSpan gap = endOfYear - now;
            Console.WriteLine("올해의 남은 날짜 : " +gap.TotalDays);
        }
    }
}
