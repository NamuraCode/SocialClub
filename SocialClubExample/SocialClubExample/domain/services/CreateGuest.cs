using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialClubExample.domain.model;

namespace SocialClubExample.domain.services
{
    public class CreateGuest
    {
        public void CreateGuest(Guest guest)
        {
            guest.status = guest.status;
            // guest.Partner = guest.Partner;
        }
    }
}