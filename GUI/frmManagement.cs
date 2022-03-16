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
    public partial class frmManagement : Form
    {
        public frmManagement()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateBook frmUpdateBook = new frmUpdateBook();
            frmUpdateBook.Show();
            frmUpdateBook.MdiParent = this;
        }

        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSearchBook frmSearchBook = new frmSearchBook();
            frmSearchBook.Show();
            frmSearchBook.MdiParent = this;
        }
    }
}
