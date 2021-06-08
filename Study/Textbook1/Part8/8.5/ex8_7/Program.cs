using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8_7
{
    class Program
    {
        internal sealed class AnonymousType0<T1, T2>
        {
            private readonly T1 V1Field;
            private readonly T2 V2Field;

            public AnonymousType0(T1 Count, T2 Title)
            {
                V1Field = Count;
                V2Field = Title;
            }

            public T1 Count{get { return V1Field;}}
            public T2 Title{get { return V2Field;}}

        }
        static void Main(string[] args)
        {
            var p = new AnonymousType0<int, string>(10, "test");
        }
    }
}
