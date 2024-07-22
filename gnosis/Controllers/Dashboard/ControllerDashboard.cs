using gnosis.Views.Dashboard;
using gnosis.Views.Administrador_de_usuarios;
using System;
using System.Linq;
using System.Windows.Forms;

namespace gnosis.Controllers.Dashboard
{
    public class ControllerDashboard
    {
        //Objeto de la vista ViewLogin
        ViewDashboard ObjDashboard;
        Form currentForm;

        public ControllerDashboard(ViewDashboard View, string username)
        {
            ObjDashboard = View;
            View.Load += new EventHandler(CargarFormPred);
            ObjDashboard.lblUsername.Text = username;
            ObjDashboard.menuAdministradorUsuarios.Click += new EventHandler(AbrirFormularioAdminUsuarios);
            ObjDashboard.cerrarFormularioToolStripMenuItem.Click += new EventHandler(CerrarForm);
            ObjDashboard.FormClosing += new FormClosingEventHandler(cerrarPrograma);
            ObjDashboard.menuVerMenu.Click += new EventHandler(menu);
        }

        public void menu(object sender, EventArgs e)
        {
            if (ObjDashboard.menuVerMenu.Text.Equals("Contraer menu"))
            {
                ObjDashboard.PanelMenu.Width = 37;
                ObjDashboard.menuVerMenu.Text = "Extender menu";
                ocultarComponetes();
            }else
            {
                mostrarComponentes();
                ObjDashboard.menuVerMenu.Text = "Contraer menu";
                ObjDashboard.PanelMenu.Width = 200;
            }
        }

        public void ocultarComponetes()
        {
            ObjDashboard.panelTop.Visible = false;
            ObjDashboard.btnAdminUser.Visible = false;
            ObjDashboard.btnLoan.Visible = false;
            ObjDashboard.btnBook.Visible = false;
            ObjDashboard.btnAccess.Visible = false;
            ObjDashboard.btnReports.Visible = false;
        }

        public void mostrarComponentes()
        {
            ObjDashboard.panelTop.Visible = true;
            ObjDashboard.btnAdminUser.Visible = true;
            ObjDashboard.btnLoan.Visible = true;
            ObjDashboard.btnBook.Visible = true;
            ObjDashboard.btnAccess.Visible = true;
            ObjDashboard.btnReports.Visible = true;
        }


        private void AbrirFormularioAdminUsuarios(object sender, EventArgs e)
        {
            AbrirFormulario<ViewAdministradorUsuarios>();
        }

        private void CargarFormPred(object sender, EventArgs e)
        {
            AbrirFormulario<ViewStatistics>();
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
            //Se cierra el formulario actual para mostrar el nuevo formulario
            currentForm.Close();
            //Se eliminan del panel contenedor todos los controles del formulario que se cerrará
            ObjDashboard.PanelContenedor.Controls.Remove(currentForm);
        }

        private void cerrarPrograma(Object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Existe una sesión activa, desea cerrar la sesión", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                
            }
            
        }
    }
}
