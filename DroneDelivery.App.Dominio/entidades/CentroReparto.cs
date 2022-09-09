using System;
using System.Collections.Generic;

namespace DroneDelivery.App.Dominio
{
    public class Warehouse 
    {
        public int Id{get;set;}
        public string Name {get;set;}
        public string TimeOpen {get;set;}
        public string TimeClose {get;set;}
        public int AcceptedShipments {get;set;}
        public int StoredShippments {get;set;}
        public int DeliveredShipments {get;set;}
        public int AssignedShipments {get;set;}
        public int DeliveryDroneCount {get;set;}
        public int AvailableDeliveries {get;set;}
        public int BusyDeliveries {get;set;}
        public int mechDeliveries {get;set;}
        public int CargoDroneCount {get;set;}
        public int AvailableCargos {get;set;}
        public int BusyCargos {get;set;}
        public int mechCargos {get;set;}
        public DroneQueue Departures {get;set;}
        public DroneQueue Arrivals {get;set;}
        public DroneQueue BatteryCharge {get;set;}
        public Location WarehouseLocation {get;set;} 
        public List<PostOfficeCarrier> Employees {get;set;}
        public List<Drone> DronesCrew {get;set;}
        public WeatherStation station {get;set;}


        private Warehouse (int id)
        {
            this.Id = id;
        }

        public Warehouse (string name, string )


    }
}