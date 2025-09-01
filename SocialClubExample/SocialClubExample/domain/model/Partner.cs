using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialClubExample.domain.model
{
    internal class Partner: User
    {
        private ulong register;
        private ulong amount;
        private string type;
        private DateTime dateCreated;

        public Partner(ulong register, ulong amount, string type, DateTime dateCreated, ulong id, string name, int age, long cellphone, long document, string userName, string password, string role)
            : base(id, name, age, cellphone, document, userName, password, role)
        {
            this.register = register;
            this.amount = amount;
            this.type = type;
            this.dateCreated = dateCreated;
        }

        public ulong Register { get => register; set => register = value; }
        public ulong Amount { get => amount; set => amount = value; }
        public string Type { get => type; set => type = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
    }
}
