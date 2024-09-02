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

namespace gnosis.Controllers.Server
{
    internal class ControllerAdminConnection
    {
        ViewAdminConnection ObjView;

        public ControllerAdminConnection(ViewAdminConnection View) 
        {
            ObjView = View;

            ///tabocontrol1
            View.btnGuardarConf.Click += new EventHandler(GuardarDatosAES);
            ///tabcontrol 2
            View.rdDeshabilitarWindows.CheckedChanged += new EventHandler(rdFalseMarked);
            View.rdHabilitarWindows.CheckedChanged += new EventHandler(rdTrueMarked);
            View.btnGuardar.Click += new EventHandler(GuardarRegistro);
            
        }

        #region Configuración AES 
        void GuardarDatosAES(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();

                //Crear declaración XML
                XmlDeclaration decl = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(decl);

                //Crear elemento raíz
                XmlElement root = doc.CreateElement("Config_AES");
                doc.AppendChild(root);

                //Crear los elementos hijos y agregarlos al elemento raíz
                XmlElement claveAES = doc.CreateElement("ClaveAES");
                string claveAEScode = CifrarCadena(ObjView.txtClaveAES.Text.Trim());
                claveAES.InnerText = claveAEScode;
                root.AppendChild(claveAES);

                XmlElement viAES = doc.CreateElement("Vector_Inicio");
                string viAEScode = CifrarCadena(ObjView.txtIV.Text.Trim());
                viAES.InnerText = viAEScode;
                root.AppendChild(viAES);

                XmlElement saltosAES = doc.CreateElement("Saltos");
                string saltosAEScode = CifrarCadena(ObjView.txtSaltos.Text.Trim());
                saltosAES.InnerText = saltosAEScode;
                root.AppendChild(saltosAES);

                doc.Save("config_AES.xml");
                MessageBox.Show($"El archivo fue creado exitosamente.", "Archivo de configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (XmlException ex)
            {
                MessageBox.Show($"{ex.Message}, no se pudo crear el archivo de configuración.", "Consulte el manual técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


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
                string servidorCode = CifrarCadena(ObjView.txtServer.Text.Trim());
                //MessageBox.Show($"{servidorCode}");
                //string servidorDecode = DescifrarCadena(servidorCode);
                //MessageBox.Show($"{servidorDecode}");
                servidor.InnerText = servidorCode;
                root.AppendChild(servidor);

                XmlElement Database = doc.CreateElement("Database");
                string DatabaseCode = CifrarCadena(ObjView.txtDatabase.Text.Trim());
                Database.InnerText = DatabaseCode;
                root.AppendChild(Database);

                if (ObjView.rdDeshabilitarWindows.Checked == true)
                {
                    XmlElement SqlAuth = doc.CreateElement("SqlAuth");
                    string sqlAuthCode = CifrarCadena(ObjView.txtSqlAuth.Text.Trim());
                    SqlAuth.InnerText = sqlAuthCode;
                    root.AppendChild(SqlAuth);

                    XmlElement SqlPass = doc.CreateElement("SqlPass");
                    string SqlPassCode = CifrarCadena(ObjView.txtSqlPass.Text.Trim());
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
                doc.Save("config_server.xml");
                MessageBox.Show($"El archivo fue creado exitosamente.", "Archivo de configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (XmlException ex)
            {
                MessageBox.Show($"{ex.Message}, no se pudo crear el archivo de configuración.","Consulte el manual técnico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        #endregion

        public string CifrarCadena(string cadena)
        {
            byte[] clave = new byte[32];
            byte[] iv = new byte[16];
            RandomNumberGenerator rng;
            using (rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(clave);
            }
            rng.GetBytes(iv);

            // Cifrar el texto
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = clave;
                aesAlg.IV = iv;
                
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))

                        {
                            swEncrypt.Write(cadena);
                        }
                    }

                    byte[] bytes = msEncrypt.ToArray();

                    // Codificar a Base64
                    return Convert.ToBase64String(bytes);
                }
            }
        }

        public string CifradoAES(string textoacifrar, string password, string vectordeinicio, int saltos)
        {
            AesManaged aes = null;
            MemoryStream streamenmemoria = null;
            CryptoStream streamcifrado = null;
            try
            {
                var rfc2898 = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes(vectordeinicio), saltos);
                aes = new AesManaged();
                aes.Key = rfc2898.GetBytes(32);
                aes.IV = rfc2898.GetBytes(16);
                streamenmemoria = new MemoryStream();
                streamcifrado = new CryptoStream(streamenmemoria, aes.CreateEncryptor(), CryptoStreamMode.Write);
                byte[] datos = Encoding.UTF8.GetBytes(textoacifrar);
                streamcifrado.Write(datos,0, datos.Length);
                streamcifrado.FlushFinalBlock();
                return Convert.ToBase64String(streamenmemoria.ToArray());
            }
            catch (Exception ex)
            {
                return "error";
            }
            finally 
            {
                
            }
        }


    }
}
