using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DatabaseConnection
    {
        protected string connectString = "Data Source=localhost;Initial Catalog=LibraryManagementSystem;Persist Security Info=True;User ID=sa;Password=123456";
        protected SqlConnection conn;
        public void OpenConnection()
        {
            if (conn == null) conn = new SqlConnection(connectString);
            if (conn.State == ConnectionState.Closed) conn.Open();
        }
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open) conn.Close();
        }
    }
}
