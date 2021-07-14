using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_12
{
    interface IVector
    {
        void Insert(int n);
        void ScalarSum(int n);
        void PrintVector();
    }

    struct Vector : IVector
    {
        private int[] v;
        private int index, size;
        public Vector(int size)
        {
            v = new int[size];
            this.size = size;
            index = 0;
        }

        public void Insert(int n)
        {
            if(index >= size)
                Console.WriteLine("Error : array overflow");
            else
                v[index++] = n;
        }

        public void ScalarSum(int n)
        {
            for(int i = 0; i < index; i++) v[i] += n;
        }
        public void PrintVector()
        {
            Console.WriteLine("Contents:");
            for(int i = 0; i < index; i++)
                Console.WriteLine(" " + v[i]);
                Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(100);
            int n;
            while(true)
            {
                n = Console.Read() - '0';
                if(n == 0) break;
                a.Insert(n);
            }
            a.PrintVector();
            a.ScalarSum(10);
            a.PrintVector();
            
        }
    }
}
