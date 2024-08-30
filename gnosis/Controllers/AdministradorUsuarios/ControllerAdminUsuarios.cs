using gnosis.Controllers.Helper;
using gnosis.Models.DAO;
using gnosis.Views.Administrador_de_usuarios;
using System;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using gnosis.Views.Reports.Persons;

namespace gnosis.Controllers.AdministradorUsuarios
{
    class ControllerAdminUsuarios
    {
        ViewAdministradorUsuarios ObjAdminUser;
        public ControllerAdminUsuarios(ViewAdministradorUsuarios Vista)
        {
            ObjAdminUser = Vista;
            ObjAdminUser.Load += new EventHandler(LoadData);
            //Evento click de botón
            ObjAdminUser.btnNuevo.Click += new EventHandler(NewUser);
            ObjAdminUser.cmsActualizar.Click += new EventHandler(UpdateUser);
            ObjAdminUser.cmsEliminar.Click += new EventHandler(DeleteUser);
            ObjAdminUser.cmsFicha.Click += new EventHandler(ViewData);
            //ObjAdminUser.txtSearch.KeyPress += new KeyPressEventHandler(Search);
            ObjAdminUser.btnBuscar.Click += new EventHandler(BuscarPeronasControllerEvent);
            ObjAdminUser.chkUserDisabled.CheckedChanged += new EventHandler(Checked);
            ObjAdminUser.restablecerContraseñaToolStripMenuItem.Click += new EventHandler(RestartPassword);
            ObjAdminUser.btnRepGeneralUsuarios.Click += new EventHandler(GenerarReporte);
        }

        void GenerarReporte(object sender, EventArgs e)
        {
            ViewGeneralPersons openForm = new ViewGeneralPersons();
            openForm.ShowDialog();
        }

        public void Search(object sender, KeyPressEventArgs e)
        {
            BuscarPeronasController();
        }

        public void Checked(object sender, EventArgs e)
        {
            RefrescarData();
        }

        public void BuscarPeronasControllerEvent(object sender, EventArgs e) { BuscarPeronasController(); }
        void BuscarPeronasController()
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOAdminUsers objAdmin = new DAOAdminUsers();
            //Declarando nuevo DataSet para que obtenga los datos del metodo ObtenerPersonas
            DataSet ds = objAdmin.BuscarPersonas(ObjAdminUser.txtSearch.Text.Trim());
            //Llenar DataGridView
            ObjAdminUser.dgvPersonas.DataSource = ds.Tables["viewPerson"];
        }

        public void LoadData(object sender, EventArgs e)
        {
            RefrescarData();
        }

        //DataGridView
        public void RefrescarData()
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOAdminUsers objAdmin = new DAOAdminUsers();
            DataSet ds = new DataSet();
            if (ObjAdminUser.chkUserDisabled.Checked != true)
            {
                //Declarando nuevo DataSet para que obtenga los datos del metodo ObtenerPersonas
                ds = objAdmin.ObtenerPersonas();
            }
            else
            {
                ds = objAdmin.ObtenerPersonasInactivas();
            }
            ObjAdminUser.dgvPersonas.DataSource = ds.Tables["viewPerson"];
            ObjAdminUser.dgvPersonas.Columns[0].Visible = false;
            ObjAdminUser.dgvPersonas.Columns[3].Visible = false;
            ObjAdminUser.dgvPersonas.Columns[10].Visible = false;
        }

        #region Código para generar columnas de editar y eliminar
        //public void GenerarColumnaEliminarDataGrid()
        //{
        //    DataGridViewButtonColumn btnClmDel = new DataGridViewButtonColumn();
        //    btnClmDel.Name = "Eliminar";
        //    ObjAdminUser.dgvPersonas.Columns.Add(btnClmDel);
        //}
        //public void GenerarColumnaEditarDataGrid()
        //{
        //    DataGridViewButtonColumn btnClmEdit = new DataGridViewButtonColumn();
        //    btnClmEdit.Name = "Editar";
        //    ObjAdminUser.dgvPersonas.Columns.Add(btnClmEdit);
        //}
        //public void FormatoColumnaGrid(Object sender, DataGridViewCellPaintingEventArgs e)
        //{
        //    if (e.ColumnIndex >= 0 && ObjAdminUser.dgvPersonas.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
        //    {
        //        e.Paint(e.CellBounds, DataGridViewPaintParts.All);
        //        DataGridViewButtonCell celboton = ObjAdminUser.dgvPersonas.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
        //        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"../../../Resources/Trash.ico");
        //        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
        //        ObjAdminUser.dgvPersonas.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
        //        ObjAdminUser.dgvPersonas.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;
        //        e.Handled = true;
        //    }
        //    else if (e.ColumnIndex >= 0 && ObjAdminUser.dgvPersonas.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
        //    {
        //        e.Paint(e.CellBounds, DataGridViewPaintParts.All);
        //        DataGridViewButtonCell celboton = ObjAdminUser.dgvPersonas.Rows[e.RowIndex].Cells["Editar"] as DataGridViewButtonCell;
        //        Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"../../../Resources/Refresh.ico");
        //        e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);
        //        ObjAdminUser.dgvPersonas.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
        //        ObjAdminUser.dgvPersonas.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;
        //        e.Handled = true;
        //    }
        //}
        #endregion

        private void NewUser(object sender, EventArgs e)
        {
            /*Se invoca al formulario ViewAddUser y se le envía un numero, este numero servirá para indicarle que tipo de acción se quiere realizar, donde 1 significa Inserción y 2 significa Actualización*/
            ViewAddUser openForm = new ViewAddUser(1);
            //Se muestra el formulario
            openForm.ShowDialog();
            //Cuando el formulario ha sido cerrado se procede a refrescar el DataGrid para que se puedan observar los nuevo datos ingresados o actualizados.
            RefrescarData();
        }

        private void UpdateUser(object sender, EventArgs e)
        {
            //Se captura el numero de la fila a la cual se le dió click, sabiendo que la primer fila tiene como valor cero.
            int pos = ObjAdminUser.dgvPersonas.CurrentRow.Index;
            /*Se invoca al formulario llamado ViewAddUser y se crea un objeto de el, posteriormente se envían los datos del datagrid al constructor del formulario según el orden establecido (se sugiere ver el código del formulario para observar ambos constructores).
             * El numero dos indicado en la linea posterior significa que la acción que se desea realizar es una actualízación.*/
            ViewAddUser openForm = new ViewAddUser(2,
                int.Parse(ObjAdminUser.dgvPersonas[0, pos].Value.ToString()),
                ObjAdminUser.dgvPersonas[1, pos].Value.ToString(),
                ObjAdminUser.dgvPersonas[2, pos].Value.ToString(),
                DateTime.Parse(ObjAdminUser.dgvPersonas[3, pos].Value.ToString()),
                ObjAdminUser.dgvPersonas[4, pos].Value.ToString(),
                ObjAdminUser.dgvPersonas[5, pos].Value.ToString(),
                ObjAdminUser.dgvPersonas[6, pos].Value.ToString(),
                ObjAdminUser.dgvPersonas[7, pos].Value.ToString(),
                ObjAdminUser.dgvPersonas[8, pos].Value.ToString(),
                ObjAdminUser.dgvPersonas[9, pos].Value.ToString());
            //Una vez los datos han sido enviados al constructor de la vista se procede a mostrar el formulario (se sugiere ver el código del constructor que esta en la vista)
            openForm.ShowDialog();
            //Una vez el formulario se haya cerrado se procederá a refrescar el dataGrid para mostrar los nuevos datos.
            RefrescarData();
        }

        private void ViewData(object sender, EventArgs e)
        {
            int pos = ObjAdminUser.dgvPersonas.CurrentRow.Index;
            int id;
            string firstName, lastName, dni, address, email, phone, username, role;
            DateTime birthday;

            id = int.Parse(ObjAdminUser.dgvPersonas[0, pos].Value.ToString());
            firstName = ObjAdminUser.dgvPersonas[1, pos].Value.ToString();
            lastName = ObjAdminUser.dgvPersonas[2, pos].Value.ToString();
            birthday = DateTime.Parse(ObjAdminUser.dgvPersonas[3, pos].Value.ToString());
            dni = ObjAdminUser.dgvPersonas[4, pos].Value.ToString();
            address = ObjAdminUser.dgvPersonas[5, pos].Value.ToString();
            email = ObjAdminUser.dgvPersonas[6, pos].Value.ToString();
            phone = ObjAdminUser.dgvPersonas[7, pos].Value.ToString();
            username = ObjAdminUser.dgvPersonas[8, pos].Value.ToString();
            role = ObjAdminUser.dgvPersonas[9, pos].Value.ToString();

            ViewAddUser openForm = new ViewAddUser(3, id, firstName, lastName, birthday, dni, address, email, phone, username, role);
            openForm.ShowDialog();
            RefrescarData();
        }
        private void DeleteUser(object sender, EventArgs e)
        {
            int pos = ObjAdminUser.dgvPersonas.CurrentRow.Index;
            string userSelected = ObjAdminUser.dgvPersonas[8, pos].Value.ToString();
            MessageBox.Show($"{userSelected}");
            if (!(userSelected.Equals(SessionVar.Username) || userSelected.Equals("Engineer")))
            {
                if (MessageBox.Show($"• Se eliminará la información de la persona, sin embargo, el usuario asociado quedará inactivo.\n\n• ¿Esta seguro que desea elimar a: {ObjAdminUser.dgvPersonas[1, pos].Value.ToString()} {ObjAdminUser.dgvPersonas[2, pos].Value.ToString()}, considere que dicha acción no se podrá revertir. \n\n• Si desea mantener la información utilice la opción de deshabilitar usuario.", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DAOAdminUsers daoDel = new DAOAdminUsers();
                    daoDel.PersonId = int.Parse(ObjAdminUser.dgvPersonas[0, pos].Value.ToString());
                    daoDel.User = ObjAdminUser.dgvPersonas[8, pos].Value.ToString();
                    int valorRetornado = daoDel.EliminarUsuario();
                    if (valorRetornado == 2)
                    {
                        MessageBox.Show("Registro eliminado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefrescarData();
                    }
                    else
                    {
                        MessageBox.Show("Registro no pudo ser eliminado, verifique que el registro no tenga datos asociados.", "Acción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No puede eliminar al usuario ya que la sesión está activa, cierre sesión en todos los dispositivos y vuelva a intentarlo.","Error de proceso",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }          
        }

        void RestartPassword(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de restablecer la contraseña del usuario que ha seleccionado?","Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                DAOAdminUsers daoRestartPassword = new DAOAdminUsers();
                CommonClasses commonClasses = new CommonClasses();
                int pos = ObjAdminUser.dgvPersonas.CurrentRow.Index;
                //Capturando nombres del usuario
                string firstName = ObjAdminUser.dgvPersonas[1, pos].Value.ToString();
                string lastName = ObjAdminUser.dgvPersonas[2, pos].Value.ToString();
                string nombrePersona = firstName + " " + lastName;
                string emailDestinatario = ObjAdminUser.dgvPersonas[6, pos].Value.ToString();
                daoRestartPassword.User = ObjAdminUser.dgvPersonas[8, pos].Value.ToString();
                //Generando PIN de seguridad y enviado PIN a la base de datos
                string pin = GenerarPin();
                daoRestartPassword.Pin = commonClasses.ComputeSha256Hash(pin);
                //Enviando PIN al correo de usuario

                if (EnviarPinPorCorreo(emailDestinatario, pin, nombrePersona) && daoRestartPassword.RegistrarPIN())
                {
                    MessageBox.Show("PIN de seguridad generado correctamente, indique al empleado que el PIN ha sido enviado a su correo registrado en el sistema.", "PIN de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El PIN no pudo ser registrado en la base de datos o no pudo enviarse al correo del destinatario, verifica la información.", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        string GenerarPin()
        {
            int longitud = 6;
            byte[] data = new byte[longitud / 2];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(data);
            }
            string hex = BitConverter.ToString(data);
            return hex.Replace("-", "").Substring(0, longitud);
        }

        bool EnviarPinPorCorreo(string emailDestinatario, string pin, string nombrePersona) 
        {
            // Configuración del correo electrónico
            #region Credenciales de correo
            string remitente = "assistent.gnosis@gmail.com";
            string contraseña = "olyrkfpgwnmrmnxx";
            #endregion
            string servidorSmtp = "smtp.gmail.com";
            int puertoSmtp = 587; // Puerto común para SMTP

            // Crear un mensaje de correo electrónico
            MailMessage mensaje = new MailMessage(remitente, emailDestinatario);
            mensaje.Subject = "🚨🚨 Restablecimiento de contraseña";
            mensaje.Body = $"Hola {nombrePersona}.\n\nEl administrador ha restablecido tu contraseña y para tu seguridad te hemos enviado un PIN el cual deberás ingresar para crear una nueva contraseña.\n\nDirigete al Inicio de Sesión y haz click en ¿Olvido su contraseña? posteriormente selecciona la opción de PIN de seguridad.\n\nEl pin que deberás introducir es: {pin}, no compartas este PIN y tampoco el acceso a tu correo electrónico registrado en el sistema.\nEn caso no solicitaste el restablecimiento de tu usuario, contacta con el administrador.";

            // Configurar el cliente SMTP
            SmtpClient clienteSmtp = new SmtpClient(servidorSmtp, puertoSmtp);
            clienteSmtp.Credentials = new NetworkCredential(remitente, contraseña);
            clienteSmtp.EnableSsl = true;

            // Enviar el correo  
            try
            {
                clienteSmtp.Send(mensaje);
                return true;
            }
            catch (SmtpException ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
                return false;

            }
        }

    }
}
