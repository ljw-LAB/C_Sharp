using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_027
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "bikang";
            string date = DateTime.Today.ToShortDateString();

            string strPlus = "Hello " + username + ". Today is " + date + ".";
            Console.WriteLine(strPlus);

            string strFomat = String.Format("Hello {0}. Today is {1}.", username, date);
            Console.WriteLine(strFomat);

            string strInterpolation = $"Hello {username}. Today is {date}";
            Console.WriteLine(strInterpolation);

            string strConcat = String.Concat("Hello ", username, ". Today is ", date, ".");
            Console.WriteLine(strConcat);

            string[] animals = {"mouse", "cow", "tiger", "rabbit", "dragon"};
            string s = String.Concat(animals);
            Console.WriteLine(s);
            s = String.Join(", ", animals);
            Console.WriteLine(s);
        }
    }
}
