using gnosis.Views.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Security.Cryptography;
using gnosis.Models.DTO;
using System.Data.SqlClient;
using gnosis.Models;

namespace gnosis.Controllers.Server
{
    internal class ControllerAdminConnection
    {
        ViewAdminConnection ObjView;
        int origen;

        public ControllerAdminConnection(ViewAdminConnection View, int origen) 
        {
            ObjView = View;
            verificarOrigen(origen);
            ///tabcontrol 2
            View.rdDeshabilitarWindows.CheckedChanged += new EventHandler(rdFalseMarked);
            View.rdHabilitarWindows.CheckedChanged += new EventHandler(rdTrueMarked);
            View.btnGuardar.Click += new EventHandler(GuardarRegistro);
            
        }

        public void verificarOrigen(int origen)
        {
            if (origen == 2)
            {
                //Cambiar configuración
                ObjView.txtServer.Text = DTOdbContext.Server;
                ObjView.txtDatabase.Text = DTOdbContext.Database;
                ObjView.txtSqlAuth.Text = DTOdbContext.User;
                ObjView.txtSqlPass.Text = DTOdbContext.Password;
            }
        }

        #region Configuración del servidor
        void rdFalseMarked(object sender, EventArgs e)
        {
            if (ObjView.rdDeshabilitarWindows.Checked == true)
            {
                ObjView.panelAuth.Enabled = true;
            }
        }

        void rdTrueMarked(object sender, EventArgs e)
        {
            if (ObjView.rdHabilitarWindows.Checked == true)
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
        public void GuardarConfiguracionXML()
        {
            try
            {
                XmlDocument doc = new XmlDocument();

                //Crear declaración XML
                XmlDeclaration decl = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(decl);

                //Crear elemento raíz
                XmlElement root = doc.CreateElement("Conn");
                doc.AppendChild(root);

                //Crear los elementos hijos y agregarlos al elemento raíz
                XmlElement servidor = doc.CreateElement("Server");
                string servidorCode = CodificarBase64String(ObjView.txtServer.Text.Trim());

                servidor.InnerText = servidorCode;
                root.AppendChild(servidor);

                XmlElement Database = doc.CreateElement("Database");
                string DatabaseCode = CodificarBase64String(ObjView.txtDatabase.Text.Trim());
                Database.InnerText = DatabaseCode;
                root.AppendChild(Database);

                if (ObjView.rdDeshabilitarWindows.Checked == true)
                {
                    XmlElement SqlAuth = doc.CreateElement("SqlAuth");
                    string sqlAuthCode = CodificarBase64String(ObjView.txtSqlAuth.Text.Trim());
                    SqlAuth.InnerText = sqlAuthCode;
                    root.AppendChild(SqlAuth);

                    XmlElement SqlPass = doc.CreateElement("SqlPass");
                    string SqlPassCode = CodificarBase64String(ObjView.txtSqlPass.Text.Trim());
                    SqlPass.InnerText = SqlPassCode;
                    root.AppendChild(SqlPass);
                }
                else
                {
                    XmlElement SqlAuth = doc.CreateElement("SqlAuth");
                    SqlAuth.InnerText = string.Empty;
                    root.AppendChild(SqlAuth);

                    XmlElement SqlPass = doc.CreateElement("SqlPass");
                    SqlPass.InnerText = string.Empty;
                    root.AppendChild(SqlPass);
                }
                SqlConnection con = dbContext.testConnection(ObjView.txtServer.Text.Trim(), ObjView.txtDatabase.Text.Trim(), ObjView.txtSqlAuth.Text.Trim(), ObjView.txtSqlPass.Text.Trim());
                if (con != null)
                {
                    doc.Save("config_server.xml");
                    DTOdbContext.Server = ObjView.txtServer.Text.Trim();
                    DTOdbContext.Database = ObjView.txtDatabase.Text.Trim();
                    DTOdbContext.User = ObjView.txtSqlAuth.Text.Trim();
                    DTOdbContext.Password = ObjView.txtSqlPass.Text.Trim();
                    MessageBox.Show($"El archivo fue creado exitosamente.", "Archivo de configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ObjView.Dispose();
                }
                
            }
            catch (XmlException ex)
            {
                MessageBox.Show($"{ex.Message}, no se pudo crear el archivo de configuración.","Consulte el manual técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        #endregion

        public string CodificarBase64String(string textoacifrar)
        {
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(textoacifrar);
                //Codificación base 64 string
                string base64String = Convert.ToBase64String(bytes);
                return base64String;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }


    }
}
