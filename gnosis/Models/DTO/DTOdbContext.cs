using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gnosis.Models.DTO
{
    internal class DTOdbContext
    {
        //*********** ARCHIVO AES ********************
        private static string clave;
        private static string vectorInicial;
        private static int saltos;

        public static string Clave { get => clave; set => clave = value; }
        public static string VectorInicial { get => vectorInicial; set => vectorInicial = value; }
        public static int Saltos { get => saltos; set => saltos = value; }

        //*********** ARCHIVO DE CONEXIÓN ***********
        private static string server;
        private static string database;
        private static string user;
        private static string password;

        public static string Server { get => server; set => server = value; }
        public static string Database { get => database; set => database = value; }
        public static string User { get => user; set => user = value; }
        public static string Password { get => password; set => password = value; }
        
    }
}
