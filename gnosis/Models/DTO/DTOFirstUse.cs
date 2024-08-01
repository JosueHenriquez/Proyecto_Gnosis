using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gnosis.Models.DTO
{
    internal class DTOFirstUse : dbContext
    {
        private string idNegocio;
        private string nombreNegocio;
        private string direccionNegocio;
        private string correoNegocio;
        private DateTime fechaNegocio;
        private string telefonoNegocio;
        private string pbxNegocio;
        private byte[] imagenNegocio;

        public string IdNegocio { get => idNegocio; set => idNegocio = value; }
        public string NombreNegocio { get => nombreNegocio; set => nombreNegocio = value; }
        public string DireccionNegocio { get => direccionNegocio; set => direccionNegocio = value; }
        public string CorreoNegocio { get => correoNegocio; set => correoNegocio = value; }
        public DateTime FechaNegocio { get => fechaNegocio; set => fechaNegocio = value; }
        public string TelefonoNegocio { get => telefonoNegocio; set => telefonoNegocio = value; }
        public string PbxNegocio { get => pbxNegocio; set => pbxNegocio = value; }
        public byte[] ImagenNegocio { get => imagenNegocio; set => imagenNegocio = value; }
    }
}
