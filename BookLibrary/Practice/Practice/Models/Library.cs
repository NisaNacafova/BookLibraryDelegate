using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Models
{
    internal class Library
    {
        public List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public Book  GetBook(Predicate<Book> predicate)
        {
            return books.Find(predicate);
        }
        public List<Book> FindAllBooks(Predicate<Book> predicate)
        {
            return books.FindAll(predicate);
        }
        public int RemoveBook(Predicate<Book> predicate)
        {
            int silinen=books.RemoveAll(predicate);
            return silinen;
        }


    }
}
