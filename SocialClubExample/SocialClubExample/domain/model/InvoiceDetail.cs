using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialClubExample.domain.model
{
    internal class InvoiceDetail
    {
        private ulong id;
        private ulong idHeader;
        private ulong idItem;
        private string description;
        private ulong price;
        public InvoiceDetail(ulong id, ulong idHeader, string description, ulong quantity, ulong price, ulong total)
        {
            this.id = id;
            this.idHeader = idHeader;
            this.description = description;
            this.price = price;
        }

        public ulong Id{ get => id; set => id = value; }
        public ulong IdHeader { get => idHeader; set => idHeader = value; }
        public ulong IdItem { get => idItem; set => idItem = value; }
        public string Description { get => description; set => description = value; }
        public ulong Price { get => price; set => price = value; }

    }
}
