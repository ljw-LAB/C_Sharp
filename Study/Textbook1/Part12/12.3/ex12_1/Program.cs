using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12_1
{
    public class IntResult
    {
        public bool Parsed {get; set;}
        public int Number {get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            IntResult result = pg.ParseInteger("15");

            Console.WriteLine(result.Parsed);
            Console.WriteLine(result.Number);
        }

        IntResult ParseInteger(string text)
        {
            IntResult result = new IntResult();
            try
            {
                result.Number = Int32.Parse(text);
                result.Parsed = true;
            }
            catch
            {
                result.Parsed = false;
            }

            return result;
        }
    }
}
