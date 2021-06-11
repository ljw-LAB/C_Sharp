using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ex11_18
{
    public class NaturalNumber : IEnumerable
    {
        List<int> numbers = new List<int>();
        public List<int> Numbers
        {
            get { return numbers; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return numbers.GetEnumerator();
        }
    }

    public static class NaturalNumberExtension
    {
        public static void Add(this NaturalNumber instance, int number)
        {
            instance.Numbers.Add(number);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NaturalNumber numbers = new NaturalNumber() { 0, 1, 2, 3, 4 };

            // C# 5.0 컴파일 오류:
            // CS1061 'NaturalNumber'에는 'Add'에 대한 정의가 포함되어 있지 않습니다.
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

    }
 
}
