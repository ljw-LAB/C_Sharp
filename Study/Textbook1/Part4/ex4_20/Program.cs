using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_20
{
    class Book
    {
        decimal _isbn;
        public decimal ISBN
        {
            get{ return this._isbn;}            
        }

        public Book(decimal isbn)
        {
            this._isbn = isbn;
        }

        public decimal GetISBN()
        {
            return this.ISBN;
        }

        public void Sell()
        {
            Console.WriteLine("Sell" + this.GetISBN());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
