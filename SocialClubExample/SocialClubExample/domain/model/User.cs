using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialClubExample.domain.model
{
    internal class User:Person
    {
        private string userName;
        private string password;
        private string role;

        public User(ulong id, string name, int age, long cellphone, long document, string userName, string password, string role) 
            : base(id, name, age, cellphone, document)
        {
            this.userName = userName;
            this.password = password;
            this.role = role;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
