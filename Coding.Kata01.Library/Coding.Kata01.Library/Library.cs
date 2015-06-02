using System.Collections.Generic;

namespace Coding.Kata01.Library
{
    public class Library
    {
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            if (Books == null) Books = new List<Book>();
            Books.Add(book);
        }

        public void RemoveBook(string isbn)
        {
            if (Books == null || Books.Count == 0) return;
            Books.Remove(Books.Find(x => x.ISBN == isbn));
        }

        public void UpdateBook(Book book)
        {
            if (Books == null || Books.Count == 0) return;
            var bookToUpdate = Books.Find(x => x.ISBN == book.ISBN);
            bookToUpdate.Title = book.Title;
            bookToUpdate.Author = book.Author;
            bookToUpdate.Categories = book.Categories;
        }

        public List<Book> AllBooks()
        {
            return Books;
        } 
    }
}
