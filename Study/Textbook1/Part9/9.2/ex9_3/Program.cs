using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;

namespace ex9_3
{
    class Program
    {
        public static CallSite<Action<CallSite, object>> p__Site1;
        static void Main(string[] args)
        {
            object d = 5;

            if (p__Site1 == null)
            {
                p__Site1 = CallSite<Action<CallSite, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded,
                    "CallTest", null, typeof(Program),
                    new CSharpArgumentInfo[] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
            }
            p__Site1.Target(p__Site1, d);

        }
    }
}
         
