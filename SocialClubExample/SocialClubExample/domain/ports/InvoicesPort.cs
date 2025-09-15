using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialClubExample.domain.model;

namespace SocialClubExample.domain.ports
{
    public class InvoicesPort
    {
        public List<InvoiceHeader> getAllInvoicesById(ulong userId) { 
            return new List<InvoiceHeader>();
        }
        public List<InvoiceDetail> getAllDetailsByIdHeader(InvoiceHeader header) {
            return new List<InvoiceDetail>();
        }
        public void DeleteInvoiceHeader(InvoiceHeader header) { }
        public void Save(InvoiceHeader header) { }
    }
}