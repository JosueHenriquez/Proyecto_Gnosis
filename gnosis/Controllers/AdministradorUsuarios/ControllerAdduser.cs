using gnosis.Controllers.Helper;
using gnosis.Models.DAO;
using gnosis.Views.Administrador_de_usuarios;
using gnosis.Views.Reports.Persons;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace gnosis.Controllers.AdministradorUsuarios
{
    class ControllerAdduser
    {
        ViewAddUser ObjAddUser;
        private int accion;
        private string role;
        //private string selectedImagePath, targetFilePath;

        /// <summary>
        /// Constructor para inserción de datos
        /// </summary>
        /// <param name="Vista"></param>
        /// <param name="accion"> INSERCIÓN </param>
        public ControllerAdduser(ViewAddUser Vista, int accion) 
        {
            //Acciones iniciales
            ObjAddUser = Vista;
            this.accion = accion;
            //Métodos iniciales: estos metodos se ejecutan cuando el formulario está cargando
            verificarAccion();
            ObjAddUser.Load += new EventHandler(InitialCharge);

            //Métodos que se ejecutan al ocurrir eventos
            ObjAddUser.btnAdd.Click += new EventHandler(NewRegister);
            ObjAddUser.btnReporteFicha.Visible = false;
        }

        /// <summary>
        /// Constructor para actualización de datos
        /// El constructor recibe al formulario, la acción y los valores que provienen de la vista.
        /// </summary>
        /// <param name="Vista"></param>
        /// <param name="accion"></param>
        /// <param name="id"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthday"></param>
        /// <param name="dni"></param>
        /// <param name="address"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        public ControllerAdduser(ViewAddUser Vista, int p_accion, int id, string firstName, string lastName, DateTime birthday, string dni, string address, string email, string phone, string username, string role)
        {
            //Acciones iniciales
            ObjAddUser = Vista;
            //Se guarda en la variable acción en vaor
            this.accion = p_accion;
            this.role = role;
            //Métodos iniciales: estos metodos se ejecutan cuando el formulario está cargando
            ObjAddUser.Load += new EventHandler(InitialCharge);
            verificarAccion();
            ChargeValues(id, firstName, lastName, birthday, dni, address, email, phone, username);
            //Métodos que se ejecutan al ocurrir eventos
            ObjAddUser.btnUpdate.Click += new EventHandler(UpdateRegister);
            ObjAddUser.btnReporteFicha.Click += new EventHandler(AbriFormularioReporte);
        }

        void AbriFormularioReporte(object sender, EventArgs e)
        {
            ViewReportSiglePerson openForm = new ViewReportSiglePerson(int.Parse(ObjAddUser.txtId.Text.Trim()));
            openForm.ShowDialog();
        }

        public void InitialCharge(object sender, EventArgs e)
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOAdminUsers objAdmin = new DAOAdminUsers();
            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombo
            DataSet ds = objAdmin.LlenarCombo();
            //Llenar combobox tbRole
            ObjAddUser.comboRole.DataSource = ds.Tables["tbRole"];
            ObjAddUser.comboRole.ValueMember = "roleId";
            ObjAddUser.comboRole.DisplayMember = "roleName";
            //La condición sirve para que al actualizar un registro, el valor del registro aparezca seleccionado.
            if (accion == 2)
            {
                ObjAddUser.comboRole.Text = role;
            }
        }
        public void verificarAccion()
        {
            ///Se verifica la acción a realizar
            ///1. Inserción de datos
            ///2. Actualización de datos
            ///3. Visualizar ficha del empleado

            if (accion == 1)
            {
                ObjAddUser.btnAdd.Enabled = true;
                ObjAddUser.btnUpdate.Enabled = false;
                ObjAddUser.btnRestablecer.Enabled = false;
                ObjAddUser.btnReporteFicha.Visible = false;
            }
            else if (accion == 2)
            {
                ObjAddUser.btnAdd.Enabled = false;
                ObjAddUser.btnUpdate.Enabled = true;
                ObjAddUser.txtUsername.Enabled = false;
                ObjAddUser.btnReporteFicha.Visible = false;
            }
            else if (accion == 3)
            {
                ObjAddUser.btnReporteFicha.Visible = true;
                ObjAddUser.btnAdd.Enabled = false;
                ObjAddUser.btnUpdate.Enabled = false;
                ObjAddUser.txtFirstName.Enabled = false;
                ObjAddUser.txtLastName.Enabled = false;
                ObjAddUser.txtEmail.Enabled = false;
                ObjAddUser.dtBirth.Enabled = false;
                ObjAddUser.mskDocument.Enabled = false;
                ObjAddUser.txtAddress.Enabled = false;
                ObjAddUser.txtPhone.Enabled = false;
                ObjAddUser.txtUsername.Enabled = false;
                ObjAddUser.comboRole.Enabled = false;
                ObjAddUser.btnRestablecer.Enabled=false;
            }
        }
        //public void SavePhoto()
        //{
        //    if (ObjAddUser.picFoto.Image != null)
        //    {
        //        //path guarda la ruta de ejecución del proyecto es decir la carpeta Debug, con Directory.GetParent retrocedemos un directorio
        //        string path = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
        //        //path2 retrocede un directorio mas basado en la ruta de path y se le agrega la ruta destino donde se guardarán la imagenes
        //        string path2 = Directory.GetParent(path) + "/Resources/Fotos".ToString();
        //        MessageBox.Show($"Ruta de imagen: {selectedImagePath}");
        //        if (File.Exists(path2+$"/{ObjAddUser.txtUsername.Text}_{selectedImagePath}"))
        //        {
                    
        //            //targetFilePath pide la ruta de destino donde se guardará la imagen y Path.GetFileName pide la ruta del archivo y extrae nada mas el nombre de la imagen ignorando toda la ruta previa.
        //            targetFilePath = Path.Combine(path2,
        //                             (ObjAddUser.txtUsername.Text + "_" + Path.GetFileName(selectedImagePath)));
        //            //Copiamos en la ruta destino la imagen.
        //            File.Copy(selectedImagePath, targetFilePath);
        //        }
        //    }
        //}
        public void NewRegister(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(ObjAddUser.txtFirstName.Text.Trim()) ||
                string.IsNullOrEmpty(ObjAddUser.txtLastName.Text.Trim()) ||
                string.IsNullOrEmpty(ObjAddUser.mskDocument.Text) ||
                string.IsNullOrEmpty(ObjAddUser.txtAddress.Text.Trim()) ||
                string.IsNullOrEmpty(ObjAddUser.txtEmail.Text.Trim()) ||
                string.IsNullOrEmpty(ObjAddUser.txtPhone.Text.Trim()) ||
                string.IsNullOrEmpty(ObjAddUser.txtUsername.Text.Trim())))
            {
                //Se crea una instancia de la clase DAOAdminUsers llamada DAOInsert
                DAOAdminUsers DAOInsert = new DAOAdminUsers();
                CommonClasses commonClasses = new CommonClasses();
                //Datos para creación de persona
                DAOInsert.FirstName = ObjAddUser.txtFirstName.Text.Trim();
                DAOInsert.LastName = ObjAddUser.txtLastName.Text.Trim();
                DAOInsert.Birthday = ObjAddUser.dtBirth.Value.Date;
                DAOInsert.Dni = ObjAddUser.mskDocument.Text;
                DAOInsert.PersonAddress = ObjAddUser.txtAddress.Text.Trim();
                DAOInsert.PersonEmail = ObjAddUser.txtEmail.Text.Trim();
                DAOInsert.PersonPhone = ObjAddUser.txtPhone.Text.Trim();
                //Datos para creación de usuario
                DAOInsert.User = ObjAddUser.txtUsername.Text.Trim();
                DAOInsert.Password = commonClasses.ComputeSha256Hash(ObjAddUser.txtUsername.Text.Trim()+"PU123");
                DAOInsert.UserStatus = true;
                DAOInsert.UserAttempts = 0;
                DAOInsert.Role = int.Parse(ObjAddUser.comboRole.SelectedValue.ToString());
                //Se invoca al método RegistrarUsuario mediante el objeto DAOInsert
                int valorRetornado = DAOInsert.RegistrarUsuario();
                //Se verifica el valor que retornó el metodo anterior y que fue almacenado en la variable valorRetornado
                if (valorRetornado == 1)
                {
                    //SavePhoto();       
                    MessageBox.Show("Los datos han sido registrados exitosamente",
                                    "Proceso completado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Los datos no pudieron ser registrados",
                                    "Proceso interrumpido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacíos, complete cada uno de los apartados y verifique que la fecha seleccionada corresponde a una persona mayor de edad.",
                                    "Proceso interrumpido",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }            
        }//Fin del metodo NewRegister
        public void UpdateRegister(object sender, EventArgs e)
        {
            DAOAdminUsers daoUpdate = new DAOAdminUsers();
            daoUpdate.PersonId = int.Parse(ObjAddUser.txtId.Text.Trim());
            daoUpdate.FirstName = ObjAddUser.txtFirstName.Text.Trim();
            daoUpdate.LastName = ObjAddUser.txtLastName.Text.Trim();
            daoUpdate.Birthday = ObjAddUser.dtBirth.Value;
            daoUpdate.Dni = ObjAddUser.mskDocument.Text.Trim();
            daoUpdate.PersonAddress = ObjAddUser.txtAddress.Text.Trim();
            daoUpdate.PersonEmail = ObjAddUser.txtEmail.Text.Trim();
            daoUpdate.PersonPhone = ObjAddUser.txtPhone.Text.Trim();
            daoUpdate.Role = (int)ObjAddUser.comboRole.SelectedValue;
            daoUpdate.User = ObjAddUser.txtUsername.Text.Trim();
            int valorRetornado = daoUpdate.ActualizarUsuario();
            if (valorRetornado == 2)
            {
                MessageBox.Show("Los datos han sido actualizado exitosamente",
                                "Proceso completado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else if (valorRetornado == 1)
            {
                MessageBox.Show("Los datos no pudieron ser actualizados completamente",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Los datos no pudieron ser actualizados debido a un error inesperado",
                                "Proceso interrumpido",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        public void ChargeValues(int id, string firstName, string lastName, DateTime birthday, string dni, string address, string email, string phone, string username)
        {
            try
            {
                ObjAddUser.txtId.Text = id.ToString();
                ObjAddUser.txtFirstName.Text = firstName;
                ObjAddUser.txtLastName.Text = lastName;
                ObjAddUser.dtBirth.Value = birthday;
                ObjAddUser.mskDocument.Text = dni;
                ObjAddUser.txtAddress.Text = address;
                ObjAddUser.txtEmail.Text = email;
                ObjAddUser.txtPhone.Text = phone;
                ObjAddUser.txtUsername.Text = username;

                //Carga sobre Label
                ObjAddUser.LblNombre.Text = firstName;
                ObjAddUser.LblApellidos.Text = lastName;
                ObjAddUser.LblUsuario.Text = username;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        
        //public void ChargePhoto(object sender, EventArgs e)
        //{
        //    DAOAdminUsers daoAdmin = new DAOAdminUsers();
        //    try
        //    {
        //        OpenFileDialog openFileDialog = new OpenFileDialog();
        //        openFileDialog.Filter = "Archivos JPG o JPEG |*.jpg; *.jpeg|Archivos PNG |*.png";
        //        openFileDialog.Title = "Seleccione una imagen";
        //        if (openFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            //selectedImagePath guarda la ruta donde esta ubicada la imagen
        //            selectedImagePath = openFileDialog.FileName;
        //            Image image = Image.FromFile(selectedImagePath);
        //            ObjAddUser.picFoto.Image = image;
        //        }
        //    }
        //    catch (IOException ex)
        //    {
        //        MessageBox.Show($"Error al cargar la imagen: \n{ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //    }
        //}
    }
}
