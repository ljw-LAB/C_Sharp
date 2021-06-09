using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ex9_5
{
    interface IBird
    {
        void Fly();
    }

    class Duck : IBird
    {
        public void Fly()
        {
            Console.WriteLine("Duck fly");
        }
    }

    class Goose : IBird
    {
        public void Fly()
        {
            Console.WriteLine("Goose fly");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StrongTypeCall(new Duck());
            StrongTypeCall(new Goose());

            string txt = "test func";
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine(DuckTypingCall(txt, "test")); // 출력 결과: 0
            Console.WriteLine(DuckTypingCall(list, 3)); // 출력 결과: 2

        }

        static void StrongTypeCall(IBird bird)
        {
            bird.Fly();
        }

        static int DuckTypingCall(dynamic target, dynamic item)
        {
            return target.IndexOf(item);
        }
    }
}
