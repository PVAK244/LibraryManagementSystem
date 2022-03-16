
namespace DTO
{
    public class Book
    {
        public string Book_ID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int Publication_Year { get; set; }

        public Book(string book_ID, string bookName, string author, int publication_Year)
        {
            Book_ID = book_ID;
            BookName = bookName;
            Author = author;
            Publication_Year = publication_Year;
        }
    }
}
