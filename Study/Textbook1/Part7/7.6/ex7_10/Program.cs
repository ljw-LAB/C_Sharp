using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> intValue = 10;
            int target = intValue.Value;
            intValue = target;

            double? temp = null;
            Console.WriteLine(temp.HasValue);
            temp = 3.141592;
            Console.WriteLine(temp.HasValue);
            Console.WriteLine(temp.Value);
        }
    }
}
