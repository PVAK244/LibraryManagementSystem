
namespace DTO
{
    public class Borrower
    {
        public string Borrower_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Borrower(string borrower_ID, string firstName, string lastName, string address, string phone)
        {
            Borrower_ID = borrower_ID;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Phone = phone;
        }
    }
}
