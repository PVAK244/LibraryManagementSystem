using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class BookBLL
    {
        BookDAL bookDAL = new BookDAL();
        public bool InsertBook(Book b)
        {
            return bookDAL.InsertBook(b);
        }
        public bool UpdateBook(Book b)
        {
            return bookDAL.UpdateBook(b);
        }
        public bool DeleteBook(string bookID)
        {
            return bookDAL.DeleteBook(bookID);
        }

        public List<Book> getBooksByName(string name)
        {
            return bookDAL.getBooksByName(name);
        }
    }
}
