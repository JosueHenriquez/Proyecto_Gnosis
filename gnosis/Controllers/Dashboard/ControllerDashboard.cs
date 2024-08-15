using gnosis.Views.Dashboard;
using gnosis.Views.Administrador_de_usuarios;
using System;
using System.Linq;
using System.Windows.Forms;
using gnosis.Views.Server;
using gnosis.Controllers.Helper;
using gnosis.Views.Login;
using gnosis.Views.Books;

namespace gnosis.Controllers.Dashboard
{
    public class ControllerDashboard
    {
        //Objeto de la vista ViewLogin
        ViewDashboard ObjDashboard;
        Form currentForm = null;

        public ControllerDashboard(ViewDashboard View, string username)
        {
            //Se asigna al objeto ObjDashboard todo lo que proviene el objeto View del constructor
            ObjDashboard = View;
            //Se utiliza el evento Load, el cual se ejecuta de forma inmediata cuando el formulario se inicia.
            View.Load += new EventHandler(EventosIniciales);
            //Al componente lblUsername se le asigna el valor de variable de sesión
            ObjDashboard.lblUsername.Text = SessionVar.Username;
            ObjDashboard.lblPersona.Text = SessionVar.FullName;
            //Se invoca al evento AbrirFormularioAdminUsuarios para que este puede ser mostrado segú el boton que el usuario presione.
            ObjDashboard.menuAdministradorUsuarios.Click += new EventHandler(AbrirFormularioAdminUsuarios);
            ObjDashboard.btnAdminUser.Click += new EventHandler(AbrirFormularioAdminUsuarios);
            ObjDashboard.btnBook.Click += new EventHandler(AbrirFormularioLibros);
            //ObjDashboard.picAdminuser.Click += new EventHandler(AbrirFormularioAdminUsuarios);
            ObjDashboard.cerrarFormularioToolStripMenuItem.Click += new EventHandler(CerrarForm);
            ObjDashboard.FormClosing += new FormClosingEventHandler(cerrarPrograma);
            ObjDashboard.menuVerMenu.Click += new EventHandler(menu);
            ObjDashboard.btnServer.Click += new EventHandler(ConfServer);
            ObjDashboard.btnLogout.Click += new EventHandler(Logout);
        }

        /// <summary>
        /// Los eventos iniciales son aquellos que se ejecutarán de forma inmediata cuando se invoque a formualrio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void EventosIniciales(object sender, EventArgs e)
        {
            Acceso();
        }

        /// <summary>
        /// El metodo acceso determina que accesos tendrá disponibles el usuario cuando inicie sesión.
        /// </summary>
        public void Acceso()
        {
            //Estructura selectiva para evaluar los posibles valores de la vraible Access
            switch (SessionVar.Access)
            {
                case "Administrador":
                    break;
                case "Bibliotecario":
                    ObjDashboard.btnAdminUser.Visible = false;
                    ObjDashboard.btnServer.Visible = false;
                    ObjDashboard.menuAdministradorUsuarios.Visible = false;
                    break;
                default:
                    break;
            }
        }

        public void menu(object sender, EventArgs e)
        {
            if (ObjDashboard.menuVerMenu.Text.Equals("Contraer menu"))
            {
                ObjDashboard.PanelMenu.Width = 50;
                ObjDashboard.panelTop.Width = 50;
                ObjDashboard.menuVerMenu.Text = "Extender menu";
            } else
            {
                mostrarComponentes();
                ObjDashboard.menuVerMenu.Text = "Contraer menu";
                ObjDashboard.PanelMenu.Width = 200;
            }
        }

        public void mostrarComponentes()
        {
            ObjDashboard.panelTop.Visible = true;
            ObjDashboard.btnAdminUser.Visible = true;
            ObjDashboard.btnLoan.Visible = true;
            ObjDashboard.btnBook.Visible = true;
            ObjDashboard.btnAccess.Visible = true;
            ObjDashboard.btnReports.Visible = true;
            ObjDashboard.btnServer.Visible = true;
            ObjDashboard.btnLogout.Visible = true;
        }

        public void ConfServer(object sender, EventArgs e)
        {
            ViewConfirmPassword objview = new ViewConfirmPassword(ObjDashboard.lblUsername.Text);
            objview.ShowDialog();
        }

        private void AbrirFormularioAdminUsuarios(object sender, EventArgs e)
        {
            AbrirFormulario<ViewAdministradorUsuarios>();
        }

        private void AbrirFormularioLibros(object sender, EventArgs e)
        {
            AbrirFormulario<ViewBooks>();
        }

        private void CargarFormPred(object sender, EventArgs e)
        {
            //AbrirFormulario<ViewStatistics>();
        }

        /// <summary>
        /// Método para abrir formularios dentro del panel contenedor del formulario principal
        /// </summary>
        /// <typeparam name="MiForm"></typeparam>
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            //Se declara objeto de tipo Form llamada formulario
            Form formulario;
            //Se guarda en el panel contenedor del formulario principal todos los controles del formulario que desea abrir <MiForm> posteriormente se guarda todo en el objeto de tipo formulario
            formulario = ObjDashboard.PanelContenedor.Controls.OfType<MiForm>().FirstOrDefault();
            //Si el formulario no existe se procederá a crearlo de lo contrario solo se traerá al frente (ver clausula else)
            if (formulario == null)
            {
                //Se define un nuevo formulario para guardarse como nuevo objeto MiForm
                formulario = new MiForm();
                //Se especifica que el formulario debe mostrarse como ventana
                formulario.TopLevel = false;
                //Se eliminan los bordes del formulario
                formulario.FormBorderStyle = FormBorderStyle.None;
                //Se establece que se abrira en todo el espacio del formulario padre
                formulario.Dock = DockStyle.Fill;
                //Se le asigna una opacidad de 0.75
                formulario.Opacity = 0.75;
                //Se evalua el formulario actual para verificar si es nulo
                if (currentForm != null)
                {
                    //Se cierra el formulario actual para mostrar el nuevo formulario
                    currentForm.Close();
                    //Se eliminan del panel contenedor todos los controles del formulario que se cerrará
                    ObjDashboard.PanelContenedor.Controls.Remove(currentForm);
                }
                //Se establece como nuevo formulario actual el formulario que se está abriendo
                currentForm = formulario;
                //Se agregan los controles del nuevo formulario al panel contenedor
                ObjDashboard.PanelContenedor.Controls.Add(formulario);
                //Tag es una propiedad genérica disponible para la mayoría de los controles en aplicaciones .NET, incluyendo los paneles.
                ObjDashboard.PanelContenedor.Tag = formulario;
                //Se muestra el formulario en el panel contenedor
                formulario.Show();
                //Se trae al frente el formulario armado
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void CerrarForm(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                //Se cierra el formulario actual para mostrar el nuevo formulario
                currentForm.Close();
                //Se eliminan del panel contenedor todos los controles del formulario que se cerrará
                ObjDashboard.PanelContenedor.Controls.Remove(currentForm);
            }
        }

        private void cerrarPrograma(Object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea cerrar el programa directamente, considere que se cerrará la sesión de forma automática", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void Logout(Object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarVariablesSesion();
                ViewLogin backForm = new ViewLogin();
                backForm.Show();
                ObjDashboard.Dispose();
            }
        }

        void LimpiarVariablesSesion()
        {
            SessionVar.Username = string.Empty;
            SessionVar.Password = string.Empty;
            SessionVar.FullName = string.Empty;
            SessionVar.Access = string.Empty;
            SessionVar.RoleId = 0;
        }
    }
}
