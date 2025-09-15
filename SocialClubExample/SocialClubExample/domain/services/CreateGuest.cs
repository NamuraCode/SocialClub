using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialClubExample.domain.model;
using SocialClubExample.domain.ports;

namespace SocialClubExample.domain.services
{
    public class CreateGuest
    {
        public void CreateNewGuest(Guest guest){
            if(guest != null){

                GuestPort guestPort = new GuestPort();
                Guest guestByDocument = guestPort.FindByDocument(guest);
                Guest guestByUserName = guestPort.FindByUserName(guest);

                if(guestByDocument == null && guestByUserName == null){
                    guestPort.Save(guest);
                } else {
                    throw new Exception("El invitado ya existe");
                }
            } else {
                throw new Exception("El invitado no puede ser vacio");
            }
        }
    }
}