using gnosis.Controllers.Helper;
using gnosis.Models.DAO;
using gnosis.Views.Login;
using gnosis.Views.Primer_Uso;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gnosis.Controllers.FirstUse
{
    internal class ControllerCreateFirstUser
    {
        ViewCreateFirstUser ObjVista;

        public ControllerCreateFirstUser(ViewCreateFirstUser Vista) 
        {
            ObjVista = Vista;
            Vista.Load += new EventHandler(CargarCombos);
            Vista.btnAdd.Click += new EventHandler(RegistrarPrimerUsuario);
            Vista.comboRole.Enabled = false;
        }

        void CargarCombos(object sender, EventArgs e)
        {
            //Objeto de la clase DAOAdminUsuarios
            DAOAdminUsers objAdmin = new DAOAdminUsers();
            //Declarando nuevo DataSet para que obtenga los datos del metodo LlenarCombo
            DataSet ds = objAdmin.LlenarCombo();
            //Llenar combobox tbRole
            ObjVista.comboRole.DataSource = ds.Tables["tbRole"];
            ObjVista.comboRole.ValueMember = "roleId";
            ObjVista.comboRole.DisplayMember = "roleName";
        }

        void RegistrarPrimerUsuario(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(ObjVista.txtFirstName.Text.Trim()) ||
                string.IsNullOrEmpty(ObjVista.txtLastName.Text.Trim()) ||
                string.IsNullOrEmpty(ObjVista.mskDocument.Text) ||
                string.IsNullOrEmpty(ObjVista.txtAddress.Text.Trim()) ||
                string.IsNullOrEmpty(ObjVista.txtEmail.Text.Trim()) ||
                string.IsNullOrEmpty(ObjVista.txtPhone.Text.Trim()) ||
                string.IsNullOrEmpty(ObjVista.txtUsername.Text.Trim())))
            {
                //Se crea una instancia de la clase DAOAdminUsers llamada DAOInsert
                DAOAdminUsers DAOInsert = new DAOAdminUsers();
                CommonClasses commonClasses = new CommonClasses();
                //Datos para creación de persona
                DAOInsert.FirstName = ObjVista.txtFirstName.Text.Trim();
                DAOInsert.LastName = ObjVista.txtLastName.Text.Trim();
                DAOInsert.Birthday = ObjVista.dtBirth.Value.Date;
                DAOInsert.Dni = ObjVista.mskDocument.Text;
                DAOInsert.PersonAddress = ObjVista.txtAddress.Text.Trim();
                DAOInsert.PersonEmail = ObjVista.txtEmail.Text.Trim();
                DAOInsert.PersonPhone = ObjVista.txtPhone.Text.Trim();
                //Datos para creación de usuario
                DAOInsert.User = ObjVista.txtUsername.Text.Trim();
                DAOInsert.Password = commonClasses.ComputeSha256Hash(ObjVista.txtUsername.Text.Trim() + "PU123");
                DAOInsert.UserStatus = true;
                DAOInsert.UserAttempts = 0;
                DAOInsert.Role = int.Parse(ObjVista.comboRole.SelectedValue.ToString());
                //Se invoca al método RegistrarUsuario mediante el objeto DAOInsert
                int valorRetornado = DAOInsert.RegistrarUsuario();
                //Se verifica el valor que retornó el metodo anterior y que fue almacenado en la variable valorRetornado
                if (valorRetornado == 1)
                {    
                    MessageBox.Show("Los datos han sido registrados exitosamente",
                                    "Proceso completado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    MessageBox.Show($"Usuario administrador: {ObjVista.txtUsername.Text.Trim()}\nContraseña de usuario: {ObjVista.txtUsername.Text.Trim()}PU123",
                                    "Credenciales de acceso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ViewLogin login = new ViewLogin();
                    login.Show();
                    ObjVista.Hide();
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
        }
    }
}
