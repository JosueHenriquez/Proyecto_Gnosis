using gnosis.Models.DAO;
using gnosis.Views.Books;
using gnosis.Views.Reports.Books;
using System;
using System.Data;
using System.Windows.Forms;

namespace gnosis.Controllers.Books
{
    internal class ControllerBooks
    {

        ViewBooks objVista;
        //Constructor que recibe al formulario ViewBooks
        public ControllerBooks(ViewBooks vista)
        {
            objVista = vista;
            //Crear un evento para cuando se inicia el formulario
            vista.Load += new EventHandler(CargaInicial);
            //Eventos que se ejecutan cuando se hace click
            vista.btnGuardar.Click += new EventHandler(GuardarRegistro);
            vista.cmsEliminarLibro.Click += new EventHandler(EliminarRegistro);
            vista.dgvLibros.CellClick += new DataGridViewCellEventHandler(SeleccionarLibro);
            vista.btnEliminar.Click += new EventHandler(EliminarRegistroBoton);
            vista.cmsActualizarLibro.Click += new EventHandler(ActualizarRegistro);
            vista.btnActualizar.Click += new EventHandler(ActualizarRegistro);
            vista.btnReporte.Click += new EventHandler(GenerarReporte);
            vista.picAgregarProveedor.Click += new EventHandler(AbrirPanelAuxiliar);
            vista.picAgregarAlmacenamiento.Click += new EventHandler(AbrirPanelAuxiliar);
            vista.picAgregarAutor.Click += new EventHandler(AbrirPanelAuxiliar);
            vista.btnCerrarPanelAuxiliar.Click += new EventHandler(CerrarPanelAuxiliar);
        }

        void AbrirPanelAuxiliar(object sender, EventArgs e)
        {
            objVista.panelAuxiliar.Visible = true;
        }

        void CerrarPanelAuxiliar(object sender, EventArgs e)
        {
            objVista.panelAuxiliar.Visible = false;
        }

        void GenerarReporte(object sender, EventArgs e)
        {
            ViewGeneralBooks openForm = new ViewGeneralBooks();
            openForm.ShowDialog();
        }

        void CargaInicial(object sender, EventArgs e)
        {
            LlenarComboProveedores();
            LlenarComboAutores();
            LlenarComboAlmacenamiento();
            LlenarComboCategorias();
            LlenarDataGridLibros();
        }

        void LlenarComboProveedores()
        {
            //Creando un objeto de la clase DAOBooks
            DAOBooks daoProveedor = new DAOBooks();
            DataSet ds = daoProveedor.ObtenerProveedores();
            objVista.cmbProveedor.DataSource = ds.Tables["tbProvider"];
            objVista.cmbProveedor.DisplayMember = "providerName";
            objVista.cmbProveedor.ValueMember = "providerID";
        }

        void LlenarComboAutores()
        {
            //Creando un objeto de la clase DAOBooks
            DAOBooks daoAutores = new DAOBooks();
            DataSet ds = daoAutores.ObtenerAutores();
            objVista.cmbAutor.DataSource = ds.Tables["tbAuthor"];
            objVista.cmbAutor.DisplayMember = "authorName";
            objVista.cmbAutor.ValueMember = "authorId";
        }

        void LlenarComboAlmacenamiento()
        {
            //Creando un objeto de la clase DAOBooks
            DAOBooks daoAutores = new DAOBooks();
            DataSet ds = daoAutores.ObtenerAlmacenamiento();
            objVista.cmbAlmacenamiento.DataSource = ds.Tables["ViewStorage"];
            objVista.cmbAlmacenamiento.DisplayMember = "storageName";
            objVista.cmbAlmacenamiento.ValueMember = "storageId";
        }

        void LlenarComboCategorias()
        {
            //Creando un objeto de la clase DAOBooks
            DAOBooks daoAutores = new DAOBooks();
            DataSet ds = daoAutores.ObtenerCategorias();
            objVista.cmbCategoria.DataSource = ds.Tables["tbCategory"];
            objVista.cmbCategoria.DisplayMember = "categoryName";
            objVista.cmbCategoria.ValueMember = "categoryId";
        }

        void GuardarRegistro(object sender, EventArgs e)
        {
            //Verificar que los campos esten llenos
            if (!(string.IsNullOrEmpty(objVista.txtNombreLibro.Text.Trim()) || objVista.numCantidadLibros.Value == 0 || string.IsNullOrEmpty(objVista.txtISBN.Text.Trim())))
            {
                //Crear un objeto de tipo DAOBooks
                DAOBooks daoInsert = new DAOBooks();
                //Enviando valores de la vista hacia el DTO de libros
                daoInsert.NombreLibro = objVista.txtNombreLibro.Text.Trim();
                daoInsert.Stock = (int)objVista.numCantidadLibros.Value;
                daoInsert.ISBN1 = objVista.txtISBN.Text.Trim();
                if (objVista.checkDisponible.Checked == true)
                {
                    daoInsert.Disponibilidad = true;
                }
                else
                {
                    daoInsert.Disponibilidad = false;
                }
                daoInsert.ProveedorId = (int)objVista.cmbProveedor.SelectedValue;
                daoInsert.AutorId = (int)objVista.cmbAutor.SelectedValue;
                daoInsert.AlmacenamientoId = (int)objVista.cmbAlmacenamiento.SelectedValue;
                int retorno = daoInsert.RegistrarLibros();
                if (retorno == 1)
                {
                    MessageBox.Show("El libro fue registrado exitosamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarDataGridLibros();
                    LimpiarCampos();
                }
                else if (retorno == 0)
                {
                    MessageBox.Show("El libro no pudo ser registrado", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Datos faltantes, complete el formulario con la información requerida", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Método para llenar el datagridview
        /// </summary>
        void LlenarDataGridLibros()
        {
            //Creando un objeto de la clase DAOBooks
            DAOBooks daoLibros = new DAOBooks();
            DataSet ds = daoLibros.ObtenerLibros();
            objVista.dgvLibros.DataSource = ds.Tables["ViewStorageBook"];
        }

        void EliminarRegistro(object sender, EventArgs e)
        {
            //Capturando el indice de la fila
            int pos = objVista.dgvLibros.CurrentRow.Index;
            DAOBooks daoDelete = new DAOBooks();
            daoDelete.IdLibro = int.Parse(objVista.dgvLibros[0, pos].Value.ToString());
            int retorno = daoDelete.EliminarLibro();
            if (retorno == 1)
            {
                MessageBox.Show("El libro seleccionado fue eliminado", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarDataGridLibros();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("El libro seleccionado no pudo ser eliminado", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void SeleccionarLibro(object sender, DataGridViewCellEventArgs e)
        {
            int pos = objVista.dgvLibros.CurrentRow.Index;
            objVista.txtIDLibro.Text = objVista.dgvLibros[0, pos].Value.ToString();
            objVista.txtNombreLibro.Text = objVista.dgvLibros[1, pos].Value.ToString();
            objVista.numCantidadLibros.Value = int.Parse(objVista.dgvLibros[2, pos].Value.ToString());
            if (bool.Parse(objVista.dgvLibros[3, pos].Value.ToString()) == true)
            {
                objVista.checkDisponible.Checked = true;
            }
            else
            {
                objVista.checkDisponible.Checked = false;
            }
            objVista.txtISBN.Text = objVista.dgvLibros[4, pos].Value.ToString();
            objVista.cmbProveedor.SelectedValue = objVista.dgvLibros[5, pos].Value.ToString();
            objVista.cmbAutor.SelectedValue = objVista.dgvLibros[6, pos].Value.ToString();
            objVista.cmbAlmacenamiento.SelectedValue = objVista.dgvLibros[7, pos].Value.ToString();
        }

        void EliminarRegistroBoton(object sender, EventArgs e)
        {
            DAOBooks daoDelete = new DAOBooks();
            daoDelete.IdLibro = int.Parse(objVista.txtIDLibro.Text.Trim());
            int retorno = daoDelete.EliminarLibro();
            if (retorno == 1)
            {
                MessageBox.Show("El libro seleccionado fue eliminado", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarDataGridLibros();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("El libro seleccionado no pudo ser eliminado", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ActualizarRegistro(object sender, EventArgs e)
        {
            DAOBooks daoUpdate = new DAOBooks();
            daoUpdate.IdLibro = int.Parse(objVista.txtIDLibro.Text.Trim());
            daoUpdate.NombreLibro = objVista.txtNombreLibro.Text.Trim();
            daoUpdate.Stock = (int)objVista.numCantidadLibros.Value;
            if (objVista.checkDisponible.Checked == true)
            {
                daoUpdate.Disponibilidad = true;
            }
            else
            {
                daoUpdate.Disponibilidad = false;
            }
            daoUpdate.ISBN1 = objVista.txtISBN.Text.Trim();
            daoUpdate.ProveedorId = (int)objVista.cmbProveedor.SelectedValue;
            daoUpdate.AutorId = (int)objVista.cmbAutor.SelectedValue;
            daoUpdate.AlmacenamientoId = (int)objVista.cmbAlmacenamiento.SelectedValue;
            int retorno = daoUpdate.ActualizarLibro();
            if (retorno == 1)
            {
                MessageBox.Show("El libro seleccionado fue actualizado", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarDataGridLibros();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("El libro seleccionado no pudo ser actualizado", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void LimpiarCampos()
        {
            objVista.txtIDLibro.Text = string.Empty;
            objVista.txtNombreLibro.Text = string.Empty;
            objVista.txtISBN.Text = string.Empty;
            objVista.numCantidadLibros.Text = string.Empty;
            objVista.checkDisponible.Checked = false;
            objVista.cmbProveedor.SelectedIndex = 0;
            objVista.cmbAutor.SelectedIndex = 0;
            objVista.cmbAlmacenamiento.SelectedIndex = 0;
        }
    }
}
