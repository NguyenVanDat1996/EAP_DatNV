using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoRESTServiceCRUD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookServices" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BookServices.svc or BookServices.svc.cs at the Solution Explorer and start debugging.
    public class BookServices : IBookServices
    {
        static IBookRepository repository = new BookRepository();
        public string AddBook(Book book, string id)
        {
            Book item = repository.AddNewBook(book);
            return "id =" + item.BookId;
        }

        public string DeleteBook(string id)
        {
            bool deleted = repository.DeleteABook(int.Parse(id));
            if (deleted)
                return "Book with id =" + id + " deleted successfully";
            else
                return " Unable o deleted book with id = " + id;

        }

        public Book GetBookIs(string id)
        {
            return repository.GetBookById(int.Parse(id));
        }

        public List<Book> GetBookList()
        {
            return repository.GetAllBooks();
        }

        public string UpdateBook(Book book, string id)
        {
            bool updated = repository.UpdateABook(book);
            if (updated)
                return "Book with id =" + id + " updated successfully";
            else
                return " Unable o update book with id = " + id;
        }
    }
}
