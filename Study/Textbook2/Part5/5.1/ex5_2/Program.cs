using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_2
{
    class Program
    {
        private int readOnlyField = 100;
        private int writeOnlyField;

        public int ReadOnlyProperty
        {
            get{
                Console.WriteLine("In the ReadOnlyProperty ... ");
                return readOnlyField;
            }
        }
        public int WriteOnlyProperty
        {
            set{
                Console.WriteLine("In the WriteOnlyProperty ... ");
                writeOnlyField = value;
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.WriteOnlyProperty = obj.ReadOnlyProperty;
            Console.WriteLine("value = " + obj.writeOnlyField);
        }
    }
}
