using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialClubExample.domain.services
{
    public class PromotionVip
    {
        public void CreateCandidateVip(Guest guest);
        public void AproveCandidateVip(Guest guest);
        public void NotifyPartners(Guest guest);
           
    }
}