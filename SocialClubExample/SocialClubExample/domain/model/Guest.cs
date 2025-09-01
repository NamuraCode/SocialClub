using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialClubExample.domain.model
{
    internal class Guest:User
    {
        private ulong idGuest;
        private Partner partner;
        private bool status;

        public Guest(ulong idGuest, Partner partner, bool status, ulong id, string name, int age, long cellphone, long document, string userName, string password, string role)
            : base(id, name, age, cellphone, document, userName, password, role)
        {
            this.idGuest = idGuest;
            this.partner = partner;
            this.status = status;
        }
        public ulong IdGuest { get => idGuest; set => idGuest = value; }
        public Partner Partner { get => partner; set => partner = value; }
        public bool Status { get => status; set => status = value; }


    }
}
