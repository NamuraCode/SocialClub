using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialClubExample.domain.services
{
    public class DeletePartner
    {
        public boolean HasUnpaidInvoices(Partner partner);
        public void RemovePartner(Partner partner);
    }
}