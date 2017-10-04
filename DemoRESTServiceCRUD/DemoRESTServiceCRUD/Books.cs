using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DemoRESTServiceCRUD
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public int BookId { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string ISBN { get; set; }
    }

    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        Book AddNewBook(Book item);
        bool DeleteABook(int id);
        bool UpdateABook(Book item);
    }

    public class BookRepository : IBookRepository
    {
        private List<Book> books = new List<Book>();
        private int counter = 1;
        public BookRepository()
        {
            AddNewBook(new Book { Title = "C# Programing", ISBN = "232543324323" });
            AddNewBook(new Book { Title = "Java Programing", ISBN = "124567912" });
            AddNewBook(new Book { Title = "WCF Programing", ISBN = "6455632443" });
        }

        public Book AddNewBook(Book item)
        {
            if(item == null)
            throw new NotImplementedException("item");
            item.BookId = counter++;
            books.Add(item);
            return item;
        }

        public bool DeleteABook(int id)
        {
            int idx = books.FindIndex(b => b.BookId == id);
            if (idx == -1)
                return false;
            books.RemoveAll(b => b.BookId == id);
            return true;
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBookById(int id)
        {
            return books.Find(b => b.BookId == id);
        }

        public bool UpdateABook(Book item)
        {
           if(item == null)
                throw new NotImplementedException("item");
            int idx = books.FindIndex(b => b.BookId == item.BookId);
            if (idx == -1)
                return false;
            books.RemoveAt(idx);
            books.Add(item);
            return true;
        }
    }
}