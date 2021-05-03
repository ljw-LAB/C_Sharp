using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_3
{
    class Book
    {
        public string Title;
        public decimal ISBN13;
        public string Contents;
        public string Author;
        public int PageCount;

        public void Open()
        {
            Console.WriteLine("Book is opened");
        }

        public void Close()
        {
            Console.WriteLine("Book is closed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.Open();
            b.Close();
        }
    }
}
