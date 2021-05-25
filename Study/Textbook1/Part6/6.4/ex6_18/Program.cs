using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ex6_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            q.Enqueue(1);
            q.Enqueue(5);
            q.Enqueue(3);

            int first = (int)q.Dequeue();

            q.Enqueue(7);

            while(q.Count > 0)
            {
                Console.Write(q.Dequeue() + ", ");
            }

        }
    }
}
