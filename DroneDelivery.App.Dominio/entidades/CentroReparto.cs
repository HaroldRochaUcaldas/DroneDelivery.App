using System;
using System.Collections.Generic;

namespace DroneDelivery.App.Dominio
{
    public class Warehouse 
    {
        public int Id{get;set;}
        public string TimeOpen {get;set;}
        public string TimeClose {get;set;}
        public int AcceptedShipments {get;set;}
        public int StoredShippments {get;set;}
        public int DeliveredShipments {get;set;}
        public int AssignedShipments {get;set;}
        public int DeliveryCount {get;set;}
        public int AvailableDeliveries {get;set;}
        public int BusyDeliveries {get;set;}
        public int mechDeliveries {get;set;}
        public int CarrierCount {get;set;}
        public int AvailableCarriers {get;set;}
        public int BusyCarriers {get;set;}
        public int mechCarriers {get;set;}
                

    }
}