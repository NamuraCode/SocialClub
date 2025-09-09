using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialClubExample.domain.model;

namespace SocialClubExample.domain.ports
{
    public class Invoices
    {
        public List<InvoiceHeader> getAllInvoicesByIdHeader(InvoiceHeader header);
        public List<InvoiceDetail> getAllDetailsByIdHeader(InvoiceHeader header);
        public void DeleteInvoiceHeader(InvoiceHeader header);
        public void Save(InvoiceHeader header);
    }
}