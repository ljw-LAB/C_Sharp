using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_46
{
    struct DivideResult
    {
        public bool Success;
        public int Result;
    }

    class Program
    {
        DivideResult Divide1(int n1, int n2)
        {
            DivideResult ret = new DivideResult();

            if (n2 == 0)
            {
                ret.Success = false;
                return ret;
            }

            ret.Success = true;
            ret.Result = n1 / n2;
            return ret;
        }

        static bool Divide2(int n1, int n2, out int result)
        {
            if (n2 == 0)
            {
                result = 0;
                return false;
            }

            result = n1 / n2;
            return true;
        }

        static void Main(string[] args)
        {
            int quotient;

            if (Divide2(15, 3, out quotient) == true)
            {
                Console.WriteLine(quotient);
            }
        }
    }
}
