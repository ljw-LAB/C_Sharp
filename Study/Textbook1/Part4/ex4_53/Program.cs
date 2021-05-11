using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_53
{
    class Notebook
    {
        int inch;
        int memoryGB;

        public Notebook(int inch, int memoryGB)
        {
            this.inch = inch;
            this.memoryGB = memoryGB;
        }

        public int this[string propertyName]
        {
            get
            {
                switch(propertyName)
                {
                    case "인치" : 
                        return inch;
                    case "메모리크기" :
                        return memoryGB;
                }

                return -1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notebook normal = new Notebook(13, 4);
            Console.WriteLine("모니터 인치 : " + normal["인치"] + "\"");
            Console.WriteLine("메모리 크기 : " + normal["메모리크기"] + "GB");

        }
    }
}
