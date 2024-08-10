using gnosis.Controllers.Helper;
using gnosis.Models.DAO;
using gnosis.Views.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gnosis.Controllers.Login
{
    internal class ControllerCambiarClaveDefecto
    {
        ViewCambiarClaveDefecto vista;

        public ControllerCambiarClaveDefecto(ViewCambiarClaveDefecto vista)
        {
            this.vista = vista;
            vista.btnCambiarClave.Click += new EventHandler(CambiarClaveDefecto);
        }

        void CambiarClaveDefecto(object sender, EventArgs e)
        {
            DAOAdminUsers daoUpdatePassword = new DAOAdminUsers();
            daoUpdatePassword.User = vista.txtUsuario.Text.Trim();
            if (vista.txtNuevaContra.Text.Trim().Equals(vista.txtConfirmarNuevaContra.Text.Trim()))
            {
                CommonClasses common = new CommonClasses();
                daoUpdatePassword.Password = common.ComputeSha256Hash(vista.txtConfirmarNuevaContra.Text.Trim());
                if (daoUpdatePassword.RestablecerContrasena())
                {
                    MessageBox.Show("Contraseña actualizada con exito.","Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Contraseña no pudo ser actualizada.", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
        }
    }
}

