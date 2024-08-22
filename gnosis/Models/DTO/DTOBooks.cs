using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gnosis.Models.DTO
{
    internal class DTOBooks : dbContext
    {
        private int idLibro;
        private string nombreLibro;
        private int stock;
        private bool disponibilidad;
        private string ISBN;
        private int proveedorId;
        private int autorId;
        private int almacenamientoId;
        private int categoriaId;

        public int IdLibro { get => idLibro; set => idLibro = value; }
        public string NombreLibro { get => nombreLibro; set => nombreLibro = value; }
        public int Stock { get => stock; set => stock = value; }
        public bool Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public int ProveedorId { get => proveedorId; set => proveedorId = value; }
        public int AutorId { get => autorId; set => autorId = value; }
        public int AlmacenamientoId { get => almacenamientoId; set => almacenamientoId = value; }
        public int CategoriaId { get => categoriaId; set => categoriaId = value; }
    }
}
