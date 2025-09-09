using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialClubExample.domain.model
{
    internal class PartnerPort
    {
        public int CountActiveGuest(Partner partner);
        public Partner FindByDocument(Partner partner);
        public Partner FindByUserName(Partner partner);
        public void DeletePartner(Partner partner);
        public List<InvoiceHeader> getAllInvoicesByIdPartner(Partner partner);
        public List<InvoiceHeader> getAllGuestsInvoicesById(Partner partner);
        public void Save(Partner partner);
    }
}
