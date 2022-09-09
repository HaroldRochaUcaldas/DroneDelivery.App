using System;
using System.Collections.Generic;

namespace DroneDelivery.App.Dominio
{
    public class PostOfficeCarrier : Person
    {
        public int Id {get;set;}
        public int AssignedShipments {get;set;}
        public int ShipmentsInProgress {get;set;}
        public int DoneShipments {get;set;}
    }
}
