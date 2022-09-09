using System;
using System.Collections.Generic;

namespace DroneDelivery.App.Dominio
{
    public class PostOfficeClerk : Person 
    {
        public int IdClerk {get;set;}
        private PostOfficeClerk (int id)
        {
            this.IdClerk = id;
        }

        public void CreateShipment ()
        {
            
        }


    }
    
}