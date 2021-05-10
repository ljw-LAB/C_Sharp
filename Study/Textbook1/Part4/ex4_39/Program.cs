using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ex4_39
{
    class Hardware{}

    class USB
    {
        string name;
        public USB(string name) {this.name = name;}

        public override string ToString()
        {
            return name;
        }
    }

    class Notebook : Hardware, IEnumerable
    {
        USB[] usbList = new USB[] { new USB("USB1"), new USB("USB2")};
        
        public IEnumerator GetEnumerator()
        {
            return new USBenumerator(usbList);
        }

        public class USBenumerator : IEnumerator
        {
            int pos = -1;
            int length = 0;
            object[] list;

            public USBenumerator(USB[] usb)
            {
                list = usb;
                length = usb.Length;
            }

            public object Current
            {
                get {return list[pos];}
            }

            public bool MoveNext()
            {
                if(pos >= length - 1)
                {
                    return false;
                }

                pos++;
                return true;
            }

            public void Reset()
            {
                pos = -1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            foreach(USB usb in notebook)
            {
                Console.WriteLine(usb);
            }
        }
    }
}
