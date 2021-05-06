using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_21
{
    public class Computer
    {
        bool powerOn;
        public void Boot();
        public void Shutdown();
        public void Reset();
    }

    public class Notebook : Computer
    {
        bool fingerScan;
        public bool HasFingerScanDevice(){return fingerScan;}

        public void CloseLid()
        {
            base.Shutdown();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
