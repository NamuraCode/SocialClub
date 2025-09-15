using SocialClubExample.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialClubExample.domain.services
{
    public class CreatePartner
    {
        public void CreateNewPartner(Partner partner)
        {
            if (partner != null) {

                PartnerPort partnerPort = new PartnerPort();
                Partner partnerByDocument = partnerPort.FindByDocument(partner);
                Partner partnerByUserName = partnerPort.FindByUserName(partner);
                if (partnerByDocument == null && partnerByUserName == null)
                {
                    partnerPort.Save(partner);
                }
                else
                {
                    throw new Exception("El socio ya existe");
                }
            }
            else
            {
                throw new Exception("El socio no puede ser vacio");
            }
        }
    }
}