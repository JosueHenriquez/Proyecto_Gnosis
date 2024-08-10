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
    public partial class ViewRecuperarContrasena : Form
    {
        public ViewRecuperarContrasena()
        {
            InitializeComponent();
            ControllerMetodosDeRecuperacion next = new ControllerMetodosDeRecuperacion(this);
        }
    }
}
