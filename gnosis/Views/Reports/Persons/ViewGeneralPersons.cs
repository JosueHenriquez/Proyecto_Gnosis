using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gnosis.Views.Reports.Persons
{
    public partial class ViewGeneralPersons : Form
    {
        public ViewGeneralPersons()
        {
            InitializeComponent();
        }

        private void ViewGeneralPersons_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet_ReportPerson.tbPerson' Puede moverla o quitarla según sea necesario.
            this.tbPersonTableAdapter.DatosPersona(this.dataSet_ReportPerson.tbPerson);

            this.reportViewer1.RefreshReport();
        }
    }
}
