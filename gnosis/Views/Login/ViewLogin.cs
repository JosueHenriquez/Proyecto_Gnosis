using gnosis.Controllers.Helper;
using gnosis.Controllers.Login;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace gnosis.Views.Login
{
    public partial class ViewLogin : Form
    {
        public ViewLogin()
        {
            InitializeComponent();
            //Inicializar controlador en la vista
            ControllerLogin control = new ControllerLogin(this);
            //Se elimina los bordes del formulario
            this.FormBorderStyle = FormBorderStyle.None;
            //Se invoca el método CreateRoundRectRgn contenido en la clase Helper
            Region = Region.FromHrgn(CommonClasses.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            PasswordHide.Visible = false;
        }
    }
}
