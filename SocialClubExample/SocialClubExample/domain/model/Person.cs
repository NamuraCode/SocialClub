using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialClubExample.domain.model
{
    internal class Person
    {
        private ulong id;
        private string name;
        private long cellphone;
        private long document;
        
        public Person(ulong id, string name, int age, long cellphone, long document)
        {
            this.id = id;
            this.name = name;
            this.cellphone = cellphone;
            this.document = document;
        }

        public ulong Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public long Cellphone { get => cellphone; set => cellphone = value; }
        public long Document { get => document; set => document = value; }
    }
}
