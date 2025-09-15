using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialClubExample.domain.model;
using SocialClubExample.domain.ports;

namespace SocialClubExample.domain.services
{
    public class DeletePartner
    {
        public bool HasUnpaidInvoices(Partner partner) {
            if(partner != null)
            {
                InvoicesPort invoicePort = new InvoicesPort();
                ulong partnerRegister = partner.Register;
                List<InvoiceHeader> invoices = invoicePort.getAllInvoicesById(partnerRegister);
                if (invoices != null && invoices.Count > 0)
                {
                    foreach (var invoice in invoices)
                    {
                        if (invoice.Status == false)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new Exception("El socio no puede ser nulo");
            }
            return true;
        }
        public void RemovePartner(Partner partner) { }
    }
}