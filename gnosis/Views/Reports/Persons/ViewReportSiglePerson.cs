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
    public partial class ViewReportSiglePerson : Form
    {
        int personId;
        public ViewReportSiglePerson(int personId)
        {
            InitializeComponent();
            this.personId = personId;
        }

        private void ViewReportSiglePerson_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"{personId}");
            // TODO: esta línea de código carga datos en la tabla 'dataSet_ReportPerson.tbPerson' Puede moverla o quitarla según sea necesario.
            this.tbPersonTableAdapter.Persona_Parametrizado(this.dataSet_ReportPerson.tbPerson, personId);
            // TODO: esta línea de código carga datos en la tabla 'dataSet_InfoBussines.tbInfoBussines' Puede moverla o quitarla según sea necesario.
            this.tbInfoBussinesTableAdapter.Fill(this.dataSet_InfoBussines.tbInfoBussines);
            this.reportViewer1.RefreshReport();
        }
    }
}
