using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookStore.models;

namespace BookStore.models
{
    public class Store
    {
        private Book[] books;

        public Store(int size) {
            books = new Book[size];
        }

        public void AddBook(Book book)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == null)
                {
                    books[i] = book;
                    Console.WriteLine("Book added success.");
                    Console.WriteLine("Author: " + book.GetAuthor());
                    Console.WriteLine("Title: " + book.GetTitle());
                    Console.WriteLine("Desctription: " + book.GetDescription());
                    return;
                }
            }
            Console.WriteLine("Sorry, not enough place in store for this book");
        }
    }
}
