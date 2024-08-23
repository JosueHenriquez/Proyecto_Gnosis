using gnosis.Models.DAO;
using gnosis.Views.Reports.Books;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gnosis.Controllers.Books
{
    internal class ControllerBooks_Report
    {
        ViewReportBooks vista;

        public ControllerBooks_Report(ViewReportBooks vista)
        {
            this.vista = vista;
            this.vista.Load += new EventHandler(CargarInicial);
        }

        void CargarInicial(object sender, EventArgs e)
        {
            LlenarDatosReportViewer();
            LlenarComboCategorias();            
        }

        void LlenarComboCategorias()
        {
            //Creando un objeto de la clase DAOBooks
            DAOBooks daoAutores = new DAOBooks();
            DataSet ds = daoAutores.ObtenerCategorias();
            vista.cmbCategoria.DataSource = ds.Tables["tbCategory"];
            vista.cmbCategoria.DisplayMember = "categoryName";
            vista.cmbCategoria.ValueMember = "categoryId";
        }
        void LlenarDatosReportViewer()
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet_Book.tbBook' Puede moverla o quitarla según sea necesario.
            vista.tbBookTableAdapter.ObtenerLibros_Report(vista.dataSet_Book.tbBook);
            // TODO: esta línea de código carga datos en la tabla 'dataSet_Book.tbBook' Puede moverla o quitarla según sea necesario.
            vista.tbBookTableAdapter.ObtenerLibros_Report(vista.dataSet_Book.tbBook);

            vista.rpvBooks.RefreshReport();
            //vista.rpvBooks.RefreshReport();
        }
    }
}
