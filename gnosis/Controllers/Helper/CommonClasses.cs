using gnosis.Models.DTO;
using gnosis.Views.Login;
using gnosis.Views.Server;
using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace gnosis.Controllers.Helper
{
    public class CommonClasses
    {
        /// <summary>
        /// Método para crear bordes redondos en el formulario
        /// </summary>
        /// <param name="nLeftRect"></param>
        /// <param name="nTopRect"></param>
        /// <param name="nRightRect"></param>
        /// <param name="nBottomRect"></param>
        /// <param name="nWidthEllipse"></param>
        /// <param name="nHeightEllipse"></param>
        /// <returns></returns>
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public string ComputeSha256Hash(string rawData)
        {
            // Crear una instancia de SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Computar el hash - devuelve un arreglo de bytes
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convertir byte array a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public bool TieneAlMenos8Caracteres(string contrasena)
        {
            return contrasena.Length >= 8;
        }
        public bool ContieneAlMenosUnNumero(string contrasena)
        {
            return contrasena.Any(char.IsDigit);
        }
        public bool ContieneAlMenosUnaMayuscula(string contrasena)
        {
            return contrasena.Any(char.IsUpper);
        }
        public bool ContieneAlMenosUnaMinuscula(string contrasena)
        {
            return contrasena.Any(char.IsLower);
        }
        public bool ContieneAlMenosUnSimbolo(string contrasena)
        {
            string simbolos = "@$#_";
            return contrasena.Any(simbolo => simbolos.Contains(simbolo));
        }
        public bool EsValida(string contrasena)
        {
            return TieneAlMenos8Caracteres(contrasena) &&
                   ContieneAlMenosUnNumero(contrasena) &&
                   ContieneAlMenosUnaMayuscula(contrasena) &&
                   ContieneAlMenosUnaMinuscula(contrasena) &&
                   ContieneAlMenosUnSimbolo(contrasena);
        }

        public void LeerArchivoXMLConexion()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory().ToString(), "config_server.xml");
            if (File.Exists(path))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                XmlNode root = doc.DocumentElement;
                XmlNode servernode = root.SelectSingleNode("Server/text()");
                XmlNode databaseNode = root.SelectSingleNode("Database/text()");
                XmlNode sqlAuthNode = root.SelectSingleNode("SqlAuth/text()");
                XmlNode sqlPassNode = root.SelectSingleNode("SqlPass/text()");

                string serverCode = servernode.Value;
                string databaseCode = databaseNode.Value;
                string userCode = sqlAuthNode.Value;
                string passwordCode = sqlPassNode.Value;

                DTOdbContext.Server = DescifrarCadena(serverCode);
                DTOdbContext.Database = DescifrarCadena(databaseCode);
                DTOdbContext.User = DescifrarCadena(userCode);
                DTOdbContext.Password = DescifrarCadena(passwordCode);
                //MessageBox.Show($"{DTOdbContext.Server}, {DTOdbContext.Database}, {DTOdbContext.User}, {DTOdbContext.Password}");
            }
            else
            {
                //Crear archivo
                ViewAdminConnection openForm = new ViewAdminConnection(1);
                openForm.ShowDialog();
                ViewLogin openFormLog = new ViewLogin();
                openFormLog.Show();
            }
        }

        public string DescifrarCadena(string cadenaCode)
        {
            try
            {
                byte[] decodedBytes = Convert.FromBase64String(cadenaCode);
                // Convertir los bytes a una cadena
                string decodedString = Encoding.UTF8.GetString(decodedBytes);
                return decodedString.ToString();
            }
            catch (Exception ex)
            {
                return $"Error al descifrar: {ex.Message}";
            }
        }
    }
}