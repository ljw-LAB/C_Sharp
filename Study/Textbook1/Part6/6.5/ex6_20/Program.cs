using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex6_20
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("test.log", FileMode.Create))
            {
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write("Hello world" + Environment.NewLine);
                bw.Write("Anderson" + Environment.NewLine);
                bw.Write(32000);
                bw.Flush();
            }
        }
    }
}
