using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Utility
{
    public static T Max<T>(T item1, T item2) where  T: IComparable
    {
        if (item1.CompareTo(item2) >= 0)
        {
            return item1;
        }

        return item2;
    }
}

namespace ex7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Utility.Max(5, 6)); // 출력 결과: 6
            Console.WriteLine(Utility.Max("Abc", "def")); // 출력 결과: def
        }
    }
}
