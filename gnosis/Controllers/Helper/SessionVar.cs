using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gnosis.Controllers.Helper
{
    internal class SessionVar
    {
        private static string username = string.Empty;
        private static string access = string.Empty;
        private static string fullName = string.Empty;
        private static string password = string.Empty;
        private static int roleId = 0;

        public static string Username { get => username; set => username = value; }
        public static string Access { get => access; set => access = value; }
        public static string FullName { get => fullName; set => fullName = value; }
        public static string Password { get => password; set => password = value; }
        public static int RoleId { get => roleId; set => roleId = value; }
    }
}
