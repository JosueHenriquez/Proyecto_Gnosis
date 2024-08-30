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
    public partial class ViewGeneralBooks : Form
    {
        public ViewGeneralBooks()
        {
            InitializeComponent();
        }

        private void ViewGeneralBooks_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet_ReportBooks.tbBook' Puede moverla o quitarla según sea necesario.
            this.tbBookTableAdapter.LibrosInner(this.dataSet_ReportBooks.tbBook);

            this.reportBooks.RefreshReport();
        }
    }
}
