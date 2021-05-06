using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_27
{
    public class Currency
    {
        decimal money;
        public decimal Money{get {return money;}}

        public Currency(decimal money)
        {
            this.money = money;
        }
    }

    public class Won : Currency
    {
        public Won(decimal money) : base(money) {}
        
        public override string ToString()
        {
            return Money + "Won";
        }
        
    }

    public class Dollar : Currency
    {
        public Dollar(decimal money) : base(money) {}
        
        public override string ToString()
        {
            return Money + "Dollar";
        }
        static public implicit operator Won(Dollar dollar)
        {
            return new Won(dollar.Money * 1000m);
        }  
    }

    public class Yen : Currency
    {
        public Yen(decimal money) : base(money) {}
        
        public override string ToString()
        {
            return Money + "Yen";
        }

        static public implicit operator Won(Yen yen)
        {
            return new Won(yen.Money * 13m);
        }   
    }

    // public class Yen : Currency
    // {
    //     public Yen(decimal money) : base(money) {}
        
    //     static public implicit operator Won(Yen yen)
    //     {
    //         return new Won(yen.Money * 13m);
    //     }
        
    // }
    class Program
    {
        static void Main(string[] args)
        {
            // Won won = new Won(1000);
            // Dollar dollar = new Dollar(1);
            // Yen yen = new Yen(13);

            // won = yen;

            // Yen yen = new Yen(100);
            
            // Won won1 = yen;
            // Won won2 = (Won)yen;

            // Console.WriteLine(won1);

            Dollar dollar = new Dollar(1);

            Won won1 = dollar;
            Won won2 = (Won)dollar;

            Console.WriteLine(won2);
        }
    }
}
