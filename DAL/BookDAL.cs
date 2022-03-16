using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookDAL:DatabaseConnection
    {
        public bool InsertBook(Book b)
        {
            try
            {
                OpenConnection();
                string sql = $"insert into Book values ('{b.Book_ID}','{b.BookName}','{b.Author}',{b.Publication_Year})";
                SqlCommand command = new SqlCommand(sql, conn);
                if (command.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
            return false;
        }
        public bool UpdateBook(Book b)
        {
            try
            {
                OpenConnection();
                string sql = $"update Book set bookname='{b.BookName}',author='{b.Author}',publication_year={b.Publication_Year} " +
                    $"where book_id='{b.Book_ID}'";
                SqlCommand command = new SqlCommand(sql, conn);
                if (command.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
            return false;
        }
        public bool DeleteBook(string bookID)
        {
            try
            {
                OpenConnection();
                string sql = $"delete from book where book_id='{bookID}'";
                SqlCommand command = new SqlCommand(sql, conn);
                if (command.ExecuteNonQuery() > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public List<Book> getBooksByName(string name)
        {
            OpenConnection();
            string sql = $"select * from Book where BookName like '%{name}%'";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            List<Book> books = new List<Book>();
            while (reader.Read())
            {
                string bookID = reader.GetString(0);
                string bookName = reader.GetString(1);
                string author = reader.GetString(2);
                int publicationYear = reader.GetInt32(3);
                books.Add(new Book(bookID, bookName, author, publicationYear));
            }
            reader.Close();
            CloseConnection();
            return books;
        }
    }
}
