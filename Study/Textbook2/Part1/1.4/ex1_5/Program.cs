using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_5
{
    class CoffeeMaker
    {
        public bool onState;
        public void StartCoffeeMaker()
        {
            if(onState == true)
            {
                Console.WriteLine("The CoffeeMaker is already on. ");
            }
            else
            {
                Console.WriteLine("The CoffeeMaker is now on. ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMaker cm = new CoffeeMaker();
            cm.onState = true;
            cm.StartCoffeeMaker();
        }
    }
}
