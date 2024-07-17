using gnosis.Controllers;
using gnosis.Views.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gnosis
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //ControllerInit objController = new ControllerInit();
            //Form form = objController.IniciarFormulario();
            Application.Run(new ViewLogin());           
        }
    }
}
