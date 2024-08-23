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

namespace gnosis.Views.Reports.Books
{
    public partial class ViewReportBooks : Form
    {
        public ViewReportBooks()
        {
            InitializeComponent();
            ControllerBooks_Report control = new ControllerBooks_Report(this);
        }
    }
}
