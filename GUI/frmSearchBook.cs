using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSearchBook : Form
    {
        BookBLL bookBLL = new BookBLL();
        public frmSearchBook()
        {
            InitializeComponent();
        }

        private void txtSearchBookName_TextChanged(object sender, EventArgs e)
        {
            dgvBook.DataSource = bookBLL.getBooksByName(txtSearchBookName.Text);
        }
    }
}
