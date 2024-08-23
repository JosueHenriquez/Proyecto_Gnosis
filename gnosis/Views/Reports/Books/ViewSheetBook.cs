using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gnosis.Views.Reports.Books
{
    public partial class ViewSheetBook : Form
    {
        public ViewSheetBook()
        {
            InitializeComponent();
        }

        private void ViewSheetBook_Load(object sender, EventArgs e)
        {

            this.rpwSheetBook.RefreshReport();
        }
    }
}
