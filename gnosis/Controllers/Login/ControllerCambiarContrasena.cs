using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gnosis.Controllers.Helper;
using gnosis.Models.DAO;
using gnosis.Views.Login;

namespace gnosis.Controllers.Login
{
    internal class ControllerCambiarContrasena
    {
        ViewCambiarClave vista;
        public ControllerCambiarContrasena(ViewCambiarClave vista)
        {
            this.vista = vista;
            this.vista.btnCambiarClave.Click += new EventHandler(CambiarClave);
        }

        void CambiarClave(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(vista.txtPIN.Text.Trim()) ||
                string.IsNullOrEmpty(vista.txtUsuario.Text.Trim()) ||
                string.IsNullOrEmpty(vista.txtNuevaContra.Text.Trim()) ||
                string.IsNullOrEmpty(vista.txtConfirmarNuevaContra.Text.Trim())))
            {
                if (VerificarPIN())
                {
                    if (RestablecerClave())
                    {
                        MessageBox.Show("Contraseña restablecida con exito, ya puedes iniciar sesión con tu nueva contraseña.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vista.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña no pudo ser actualizada, vuelve a intentarlo, si el error persiste contacta al administrador del sistema.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El PIN o el usuario son incorrectos, verifique la información proporcionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos requeridos, favor completalos para establecer una nueva contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        bool VerificarPIN()
        {
            DAOAdminUsers daoVerificar = new DAOAdminUsers();
            CommonClasses commonClasses = new CommonClasses();
            daoVerificar.Pin = commonClasses.ComputeSha256Hash(vista.txtPIN.Text.Trim());
            daoVerificar.User = vista.txtUsuario.Text.Trim();
            return daoVerificar.VerificarPINSeguridad();
        }

        bool RestablecerClave()
        {
            DAOAdminUsers daoVerificar = new DAOAdminUsers();
            CommonClasses commonClasses = new CommonClasses();

            if (vista.txtNuevaContra.Text.Trim().Equals(vista.txtConfirmarNuevaContra.Text.Trim()))
            {
                if (commonClasses.EsValida((vista.txtConfirmarNuevaContra.Text.Trim())))
                {
                    daoVerificar.Password = commonClasses.ComputeSha256Hash(vista.txtConfirmarNuevaContra.Text.Trim());
                    daoVerificar.User = vista.txtUsuario.Text.Trim();
                    return daoVerificar.RestablecerContrasena();
                }
                else
                {
                    MessageBox.Show("Contraseña no pudo ser actualizada debido a que no cumple con los requisitos de seguridad, verifique al lado izquierdo de la ventana.", "Proceso incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
            }
            else
            {
                MessageBox.Show("Las contraseñas no coindicen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
