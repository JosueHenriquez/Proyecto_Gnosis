using gnosis.Controllers.Books;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gnosis.Views.Books
{
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();
            ControllerBooks control = new ControllerBooks(this);
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
