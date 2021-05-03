using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_7
{
    class Book
    {
        public string Title;
        public decimal ISBN13;
        public string Author;

        // public Book(string title)
        // {
        //     Title = title;
        // }
        // public Book(string title, decimal isbn13)
        // {
        //     Title = title;
        //     ISBN13 = isbn13;
        // }

        public Book(string title, decimal isbn13, string author)
        {
            Title = title;
            ISBN13 = isbn13;
            Author = author;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Book gulliver = new Book("걸리버 여행기");
            //Book huckleberry = new Book("허클배리 핀의 모험", 9788952753403m);
            Book alice = new Book("이상한 나라의 앨리스", 9788952752126, "Lewis Carroll");

            //Console.WriteLine(gulliver.Title);
            //Console.WriteLine(huckleberry.Title, huckleberry.ISBN13);
            Console.WriteLine("{0}, {1}, {2}", alice.Title, alice.ISBN13, alice.Author);
        }
    }
}
