using gnosis.Views.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;

namespace gnosis.Controllers.Server
{
    internal class ControllerAdminConnection
    {
        ViewAdminConnection ObjView;

        public ControllerAdminConnection(ViewAdminConnection View) 
        {
            ObjView = View;
            View.rdFalse.CheckedChanged += new EventHandler(rdFalseMarked);
            View.rdTrue.CheckedChanged += new EventHandler(rdTrueMarked);
            View.btnGuardar.Click += new EventHandler(GuardarRegistro);
        }

        void rdFalseMarked(object sender, EventArgs e)
        {
            if (ObjView.rdFalse.Checked == true)
            {
                ObjView.panelAuth.Enabled = true;
            }
        }

        void rdTrueMarked(object sender, EventArgs e)
        {
            if (ObjView.rdTrue.Checked == true)
            {
                ObjView.panelAuth.Enabled = false;
                ObjView.txtSqlAuth.Clear();
                ObjView.txtSqlPass.Clear();
            }
        }

        void GuardarRegistro(object sender, EventArgs e)
        {
            GuardarConfiguracionXML();
        }
        public static void GuardarConfiguracionXML()
        {
            //using (var writer = new XmlTextWriter(rutaArchivo))
            //{
            //    writer.Formatting = Formatting.Indented;
            //    var serializer = new XmlSerializer(typeof(ControllerAdminConnection));
            //    serializer.Serialize(writer, configuracion);
            //}
        }
    }
}
