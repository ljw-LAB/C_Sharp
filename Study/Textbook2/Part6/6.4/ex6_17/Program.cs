using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_17
{
    public class MyAttrAttribute : Attribute
    {
        public MyAttrAttribute(string message)
        {
            this.message = message;
        }
        private string message;
        public string Message
        {
            get{return message;}
        }
    }
    [MyAttr("This is Attrbute test.")]
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Program);
            object[] arr = type.GetCustomAttributes(typeof(MyAttrAttribute), true);

            if(arr.Length == 0)
                Console.WriteLine("This class no custom attrs. ");
            else
            {
                MyAttrAttribute ma = (MyAttrAttribute) arr[0];
                Console.WriteLine(ma.Message);        
            }
        }
    }
}
