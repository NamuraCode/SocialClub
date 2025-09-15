using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialClubExample.domain.model
{
    internal class PartnerPort
    {
        public int CountActiveGuest(Partner partner) { 
            return 0;
        }
        public Partner FindByDocument(Partner partner) { 
            return partner;
        }
        public Partner FindByUserName(Partner partner) { 
            return partner;
        }
        public void DeletePartner(Partner partner) { }
        public List<InvoiceHeader> getAllInvoicesByIdPartner(Partner partner) { 
            return new List<InvoiceHeader>();
        }
        public List<InvoiceHeader> getAllGuestsInvoicesById(Partner partner) { 
            return new List<InvoiceHeader>();
        }
        public void Save(Partner partner) { }
    }
}
