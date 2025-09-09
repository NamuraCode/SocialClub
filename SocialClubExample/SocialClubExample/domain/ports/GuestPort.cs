using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialClubExample.domain.model;

namespace SocialClubExample.domain.ports
{
    public class GuestPort
    {
        public Guest FindByDocument(Guest guest);
        public Guest FindByUserName(Guest guest);
        public void Save(Guest guest);
    }
}