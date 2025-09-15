using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialClubExample.domain.model
{
    public class Admin:User
    {
        public Admin(ulong id, string name, int age, long cellphone, long document, string userName, string password, string role) 
            : base(id, name, age, cellphone, document, userName, password, role)
        {
        }
    }
}