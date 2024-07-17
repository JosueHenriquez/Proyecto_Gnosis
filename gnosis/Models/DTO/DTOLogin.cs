using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gnosis.Models.DTO
{
    public class DTOLogin : dbContext
    {
        private string username;
        private string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public bool V { get; }

        public DTOLogin() { }

        public DTOLogin(bool v, string username, string password)
        {
            V = v;
            this.username = username;
            this.password = password;
        }
    }
}
