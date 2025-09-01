using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialClubExample.domain.model
{
    internal class InvoiceHeader
    {
        private ulong idInvoice;
        private User user;
        private Partner partner;
        private DateTime dateCreated;
        private ulong total;
        private bool status;
        private List<InvoiceDetail> details;

        public InvoiceHeader(ulong idInvoice, User user, Partner partner, DateTime dateCreated, ulong total, bool status)
        {
            this.idInvoice = idInvoice;
            this.user = user;
            this.partner = partner;
            this.dateCreated = dateCreated;
            this.total = total;
            this.status = status;
        }

        public ulong IdInvoice { get => idInvoice; set => idInvoice = value; }
        public User User { get => user; set => user = value; }
        public Partner Partner { get => partner; set => partner = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        public ulong Total { get => total; set => total = value; }
        public bool Status { get => status; set => status = value; }
        public List<InvoiceDetail> Details { get => details; set => details = value; }

    }
}
