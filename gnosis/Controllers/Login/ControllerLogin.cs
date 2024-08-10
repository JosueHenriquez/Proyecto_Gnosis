using gnosis.Models.DAO;
using gnosis.Views.Login;
using System;
using System.Windows.Forms;
using gnosis.Models;
using gnosis.Views.Dashboard;
using gnosis.Controllers.Helper;

namespace gnosis.Controllers.Login
{
    public class ControllerLogin
    {
        //Objeto de la vista ViewLogin
        ViewLogin ObjLogin;

        /// <summary>
        /// Constructor de la clase ControllerLogin que inicia los eventos de la vista
        /// </summary>
        /// <param name="Vista"></param>
        public ControllerLogin(ViewLogin Vista)
        {
            ObjLogin = Vista;
            ObjLogin.BtnStart.Click += new EventHandler(DataAccess);
            ObjLogin.BtnExit.Click += new EventHandler(QuitApplication);
            //Eventos para txtUsername
            ObjLogin.txtUsername.Enter += new EventHandler(EnterUsername);
            ObjLogin.txtUsername.Leave += new EventHandler(LeaveUsername);
            //Eventos para txtPassword
            ObjLogin.txtPassword.Enter += new EventHandler(EnterPassword);
            ObjLogin.txtPassword.Leave += new EventHandler(LeavePassword);
            //Eventos de Probar Conexión
            ObjLogin.BtnTest.Click += new EventHandler(TestConnection);
            ObjLogin.PasswordVisible.Click += new EventHandler(ShowPassword);
            ObjLogin.PasswordHide.Click += new EventHandler(HidePassword);
            ObjLogin.linkRecuperarContra.Click += new EventHandler(RecuperarContra);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataAccess(object sender, EventArgs e)
        {
            //Creando objeto de la clase DAOLogin
            DAOLogin DAOData = new DAOLogin();
            CommonClasses common = new CommonClasses();
            //Utilizando el objeto DAO para invocar a los metodos getter y setter del DTO
            DAOData.Username = ObjLogin.txtUsername.Text;
            string cadenaencriptada = common.ComputeSha256Hash(ObjLogin.txtPassword.Text);
            DAOData.Password = cadenaencriptada;
            //Invocando al método Login contenido en el DAO
            bool answer = DAOData.ValidarLogin();
            //MessageBox.Show("" + answer);
            //Se evalúa el valor de la variable answer
            if (answer == true && ObjLogin.txtPassword.Text.Trim() != DAOData.Username+"PU123")
            {
                ObjLogin.Hide();
                ViewDashboard viewDashboard = new ViewDashboard(ObjLogin.txtUsername.Text);
                viewDashboard.Show();
            }
            else if (answer == true && ObjLogin.txtPassword.Text.Trim() == DAOData.Username + "PU123")
            {
                ViewCambiarClaveDefecto openForm = new ViewCambiarClaveDefecto();
                openForm.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Datos incorrectos", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento se ejecuta cuando se entra o se sale al txtUsername.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterUsername(object sender, EventArgs e)
        {
            if (ObjLogin.txtUsername.Text.Trim().Equals("Usuario"))
            {
                ObjLogin.txtUsername.Clear();
                ObjLogin.LblUsername.Visible = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeaveUsername(object sender, EventArgs e)
        {
            if (ObjLogin.txtUsername.Text.Trim().Equals(""))
            {
                ObjLogin.txtUsername.Text = "Usuario";
                ObjLogin.LblUsername.Visible = false;
            }
        }

        /// <summary>
        /// Evento ejecutado cuando el elemento activo es el elemento txtPassword
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterPassword(object sender, EventArgs e)
        {
            if (ObjLogin.txtPassword.Text.Trim().Equals("Contraseña"))
            {
                ObjLogin.txtPassword.Clear();
                ObjLogin.LblPassword.Visible = true;
                //ObjLogin.txtPassword.PasswordChar = '*';
                ObjLogin.txtPassword.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// Evento ejecutado cuando elemento txtPassword deja de ser el foco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeavePassword(object sender, EventArgs e)
        {
            if (ObjLogin.txtPassword.Text.Trim().Equals(""))
            {
                ObjLogin.LblPassword.Visible = false;
                ObjLogin.txtPassword.Text = "Contraseña";
                ObjLogin.txtPassword.PasswordChar = '\0';
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestConnection(object sender, EventArgs e)
        {
            //Se hace referencia a la clase dbContext y su método getConnection y se evalúa
            // si el retorno es nulo o no, en caso de ser nulo se mostrará el primer mensaje
            //de lo contrario se mostrará el código del segmento else.
            if (dbContext.getConnection() == null)
            {
                MessageBox.Show("No fue posible realizar la conexión al servidor y/o la base de datos.", "Conexión fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                MessageBox.Show("La conexión al servidor y la base de datos se ha ejecutado correctamente.", "Conexión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// El evento KeyEnter detecta cuando la tecla enter es presionada y realizará una
        /// determinada acción.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyEnter(object sender, EventArgs e)
        {

        }

        private void ShowPassword(object sender, EventArgs e)
        {
            ObjLogin.txtPassword.UseSystemPasswordChar = false;
            ObjLogin.PasswordVisible.Visible = false;
            ObjLogin.PasswordHide.Visible = true;
        }

        private void HidePassword(object sender, EventArgs e)
        {
            ObjLogin.txtPassword.UseSystemPasswordChar = true;
            ObjLogin.PasswordVisible.Visible = true;
            ObjLogin.PasswordHide.Visible = false;
        }

        void RecuperarContra(object sender, EventArgs e)
        {
            ViewRecuperarContrasena openForm = new ViewRecuperarContrasena();
            openForm.ShowDialog();
        }
    }
}