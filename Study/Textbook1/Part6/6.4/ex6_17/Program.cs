using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // 반드시 추가 할 것 

namespace ex6_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            
            st.Push(1);
            st.Push(5);
            st.Push(3);
            
            int last = (int)st.Pop();

            st.Push(7);
            
            while(st.Count > 0)
            {
                Console.WriteLine(st.Pop() + ", ");
            }
        }
    }
}
