using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class ArrayNoException<T>
{
    int _size;
    T[] _items;

    public ArrayNoException(int size)
    {
        _size = size;
        _items = new T[size];
    }

    public T this[int index]
    {
        get
        {
            if(index >= _size)
            {
                return default(T);
            }
            return _items[index];
        }

        set
        {
            if(index >= _size)
            {
                return;
            }
            _items[index] = value;
        }
    }
}
namespace ex7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayNoException<int> list = new ArrayNoException<int>(10);
            list[10] = 5;

            Console.WriteLine(list[10]);

            int intValue = default(int);
            BigInteger bigInteger = default(BigInteger);

            Console.WriteLine(intValue);
            Console.WriteLine(bigInteger);

            string txt = default(string);
            Console.WriteLine(txt ?? "(null)");
        }
    }
}
