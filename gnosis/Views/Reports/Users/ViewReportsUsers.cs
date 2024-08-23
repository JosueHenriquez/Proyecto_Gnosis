using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gnosis.Views.Reports.Users
{
    public partial class ViewReportsUsers : Form
    {
        public ViewReportsUsers()
        {
            InitializeComponent();
        }

        private void ViewReportsUsers_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet_ReportGeneralUsers.tbPerson' Puede moverla o quitarla según sea necesario.
            this.tbPersonTableAdapter.ObtenerPersonaUsuario(this.dataSet_ReportGeneralUsers.tbPerson);

            this.reportViewer1.RefreshReport();
        }
    }
}
