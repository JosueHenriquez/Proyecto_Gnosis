using gnosis.Controllers.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gnosis.Views.Login
{
    public partial class ViewCambiarClave : Form
    {
        public ViewCambiarClave()
        {
            InitializeComponent();
            //el 1 indica que el formulario se abrira a raiz de que el administrador restableció la contraseña del usuario
            ControllerCambiarContrasena control = new ControllerCambiarContrasena(this);
        }
    }
}
