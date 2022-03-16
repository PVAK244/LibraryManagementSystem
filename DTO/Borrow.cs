using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Borrow
    {
        public string Borrower_ID { get; set; }
        public string Book_ID { get; set; }
        public string Borrowed_Date { get; set; }
        public string Return_Date { get; set; }
        public Borrow(string borrower_ID, string book_ID, string borrowed_Date, string return_Date)
        {
            Borrower_ID = borrower_ID;
            Book_ID = book_ID;
            Borrowed_Date = borrowed_Date;
            Return_Date = return_Date;
        }
    }
}
