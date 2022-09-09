using System;
using System.Collections.Generic;

namespace DroneDelivery.App.Dominio
{
    public class Branch
    {
        public int Id{get;set;}
        public string Code {get;set;}
        public City city {get;set;}
        public Manager localManager {get;set;}
        public Location location {get;set;}
        public ICollection<DeliveryZone> DeliveryZones {get;set;}

        public Branch (int id)
        {
            this.Id = id;
        }

    }
}