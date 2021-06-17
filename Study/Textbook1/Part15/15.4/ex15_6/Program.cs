using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15_6
{
    public class BaseType
    {
        private readonly bool _field = int.TryParse("5", out int result);

        int Number { get; set; } = int.TryParse("5", out int result) ? 0 : -1;
        int Number2 { get; set; } = 5 is int value ? value : 0;

        public BaseType(int number, out bool result)
        {
            Number = number;
            result = _field;
        }
    }

    public class Derived : BaseType
    {
        public Derived(int i ) : base(i, out var result)
        {
            Console.WriteLine(result);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = new string[] { "test", "is", "good"};

            var query = from text in strings
                        where int.TryParse(text, out int result)
                        select text;

            object[] objects = new object[] {5, "is", true};

            var texts = from text in objects
                        let t = text is string value ? value : ""
                        select t;  
        }
    }
}
