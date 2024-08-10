using gnosis.Views.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gnosis.Controllers.Login
{
    internal class ControllerMetodosDeRecuperacion
    {
        ViewRecuperarContrasena vista;
        public ControllerMetodosDeRecuperacion(ViewRecuperarContrasena vista)
        {
            this.vista = vista;
            vista.btnIntervencionAdministrador.Click += new EventHandler(openFormIntervencionAdmin);
        }

        void openFormIntervencionAdmin(object sender, EventArgs e)
        {
            ViewCambiarClave openForm = new ViewCambiarClave();
            openForm.ShowDialog();
        }
    }
}
