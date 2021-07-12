using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_6
{
    class PropertyClass
    {
        private int privateValue;
        public int PrivateValue
        {
            get {return privateValue;}
            set {privateValue = value;}
        }

        public void PrintValue()
        {
            Console.WriteLine("Hidden Value = " + privateValue);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           int n;
           PropertyClass obj = new PropertyClass();
           obj.PrivateValue = 100;
           obj.PrintValue();
           n = obj.PrivateValue;
           Console.WriteLine("       Value = " + n); 
        }
    }
}
