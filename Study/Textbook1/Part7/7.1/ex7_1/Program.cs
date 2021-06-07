using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OldStack
{
    object[] _objList;
    int _pos;

    public OldStack(int size)
    {
        _objList = new object[size];
    }

    public void Push(object newValue)
    {
        _objList[_pos] = newValue;
        _pos++;
    }

    public object Pop()
    {
        _pos--;
        return _objList[_pos];
    }
}
namespace ex7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            OldStack stack = new OldStack(10);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

        }
    }
}
