using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //int product1 = 5000;
            //int product2 = 5500;
            //int product3 = 6000;
            //int product4 = 10000;
            //int product5 = 60000;

            int[] products = new int[5];      // new연산자 heap 할당, malloc()역할 ?? 
            string [] names = new string[5]; //
            
            products[0] = 100;
            products[1] = 200;
            int book = products[0];
            int sum = products[0] + products[1];

            int[] product1 = new int [5] {1, 2, 3, 4, 5};
            int[] product2 = new int [] {1, 2, 3, 4, 5};

            string text = "Hello Wolrd";
            char ch1 = text[0];
            char ch2 = text[1];

            Console.WriteLine(ch1);
            Console.WriteLine(ch2);

            int []  students = new int[60];
            students[0] = 50;
            Console.WriteLine(students[0]);

            int[] students1 = new int[60];
            students1 = new int[120];
            Console.WriteLine(students1[0]);


        }
    }
}
