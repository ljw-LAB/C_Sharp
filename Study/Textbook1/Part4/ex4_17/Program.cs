using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_17
{
    class Book
    {
        decimal _isbn;
        
        public Book(decimal isbn)
        {
            _isbn = isbn;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine(n.Equals(5));
            
            int n1 = 5;
            int n2 = 5;
            Console.WriteLine(n1.Equals(n2));

            n2 = 6;
            Console.WriteLine(n1.Equals(n2));

            Book book1 = new Book(9788998139018);
            Book book2 = new Book(9788998139018);

            Console.WriteLine(book1.Equals(book2));

            string txt1 = new string(new char[] {'t', 'e', 'x', 't'});
            string txt2 = new string(new char[] {'t', 'e', 'x', 't'});

            Console.WriteLine(txt1.Equals(txt2));
        }
    }
}
