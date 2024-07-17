using System.Windows.Forms;
using gnosis.Controllers.AdministradorUsuarios;

namespace gnosis.Views.Administrador_de_usuarios
{
    public partial class ViewAdministradorUsuarios : Form
    {
        public ViewAdministradorUsuarios()
        {
            InitializeComponent();
            ControllerAdminUsuarios ObjAdminUser = new ControllerAdminUsuarios(this);
        }
    }
}
