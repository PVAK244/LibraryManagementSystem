using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmUpdateBook : Form
    {
        BookBLL bookBLL = new BookBLL();
        public frmUpdateBook()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Book b = new Book(txtBookID.Text, txtBookName.Text, txtAuthor.Text, int.Parse(txtPublicationYear.Text));
                if (bookBLL.InsertBook(b)) MessageBox.Show("Insert Sucessfully!!!");
                else MessageBox.Show("Insert Failed!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string bookID = txtBookID.Text;
            if (bookBLL.DeleteBook(bookID))
            {
                MessageBox.Show("Delete Sucessfully!!!");
                txtBookID.Text = "";
                txtBookName.Text = "";
                txtAuthor.Text = "";
                txtPublicationYear.Text = "";
            }
            else
            {
                MessageBox.Show("Delete failed!!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Book b = new Book(txtBookID.Text, txtBookName.Text, txtAuthor.Text, int.Parse(txtPublicationYear.Text));
                if (bookBLL.UpdateBook(b)) MessageBox.Show("Update Sucessfully!!!");
                else
                    MessageBox.Show("Update failed!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update");
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
