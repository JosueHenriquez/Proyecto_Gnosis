using gnosis.Models.DAO;
using gnosis.Views.Primer_Uso;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace gnosis.Controllers.FirstUse
{
    internal class ControllerFirstUse
    {
        ViewFirstUse ObjVista;
        bool realizarAccion;
        public ControllerFirstUse(ViewFirstUse Vista) 
        {
            ObjVista = Vista;
            Vista.btnSave.Click += new EventHandler(GuardarInformacion);
            Vista.btnAttach.Click += new EventHandler(ColocarImagenPicture);
            Vista.btnCerrar.Click += new EventHandler(CerrarPrograma);
        }

        void CerrarPrograma(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



        void GuardarInformacion(object sender, EventArgs e)
        {
            try
            {
                //Validación para verificar que todos los campos esten llenos
                if (!(string.IsNullOrEmpty(ObjVista.txtNameBussines.Text.Trim()) ||
                    string.IsNullOrEmpty(ObjVista.txtAddressBussines.Text.Trim()) ||
                    string.IsNullOrEmpty(ObjVista.txtEmailBussines.Text.Trim()) ||
                    string.IsNullOrEmpty(ObjVista.txtPhone.Text.Trim()) ||
                    string.IsNullOrEmpty(ObjVista.txtPbx.Text.Trim()) ||
                    ObjVista.picBussines.Image == null))
                {
                    DAOFirstUse DAOGuardar = new DAOFirstUse();
                    DAOGuardar.NombreNegocio = ObjVista.txtNameBussines.Text.Trim();
                    DAOGuardar.DireccionNegocio = ObjVista.txtAddressBussines.Text.Trim();
                    DAOGuardar.CorreoNegocio = ObjVista.txtEmailBussines.Text.Trim();
                    DAOGuardar.FechaNegocio = ObjVista.dtCreation.Value.Date;
                    DAOGuardar.TelefonoNegocio = ObjVista.txtPhone.Text.Trim();
                    DAOGuardar.PbxNegocio = ObjVista.txtPbx.Text.Trim();

                    //Guardar imagen
                    Image imagen = ObjVista.picBussines.Image;
                    byte[] imageBytes;
                    if (imagen == null)
                    {
                        imageBytes = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream();
                        imagen.Save(ms, ImageFormat.Jpeg);
                        imageBytes = ms.ToArray();
                    }
                    realizarAccion = ValidarCorreo();
                    if (realizarAccion == true)
                    {
                        DAOGuardar.ImagenNegocio = imageBytes;
                        bool respuesta = DAOGuardar.RegistrarNegocio();
                        if (respuesta != false)
                        {
                            MessageBox.Show($"Tu biblioteca ha sido registrada exitosamente.", "Paso 1 completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ViewCreateFirstUser nextForm = new ViewCreateFirstUser();
                            nextForm.Show();
                            ObjVista.Dispose();
                        }
                        else
                        {
                            MessageBox.Show($"Oops, algo salio mal, revisemos los datos e intentemos nuevamente.", "Paso 1 interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                    
                }
                else
                {
                    MessageBox.Show($"Todos los campos son requeridos.", "Datos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error al procesar información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ColocarImagenPicture(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png| Todos los archivos(*.*)| *.* ";
            ofd.Title = "Seleccionar imagen";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = ofd.FileName;
                ObjVista.picBussines.Image = Image.FromFile(rutaImagen);
            }
        }

        bool ValidarCorreo()
        {
            string email = ObjVista.txtEmailBussines.Text.Trim();
            if (!(email.Contains("@")))
            {
                MessageBox.Show("Formato de correo invalido, verifica que contiene @.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //josueguinea@gmail.com

            // Validación del dominio (ejemplo simplificado)
            string[] dominiosPermitidos = { "gmail.com","ricaldone.edu.sv"};
            string extension = email.Substring(email.LastIndexOf('@') + 1);
            if (!dominiosPermitidos.Contains(extension))
            {
                MessageBox.Show("Dominio del correo es invalido, el sistema unicamente admite dominios 'gmail.com' y 'correo institucional'.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
