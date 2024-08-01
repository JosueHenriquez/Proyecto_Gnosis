using gnosis.Controllers.FirstUse;
using gnosis.Controllers.Helper;
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

namespace gnosis.Views.Primer_Uso
{
    public partial class ViewFirstUse : Form
    {
        public ViewFirstUse()
        {
            InitializeComponent();
            //Inicializar controlador en la vista
            ControllerFirstUse control = new ControllerFirstUse(this);
            //Se elimina los bordes del formulario
            this.FormBorderStyle = FormBorderStyle.None;
            //Se invoca el método CreateRoundRectRgn contenido en la clase Helper
            Region = Region.FromHrgn(CommonClasses.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
    }
}
