using System;

namespace DroneDelivery.App.Dominio
{
    public class Location
    {
        public int Id {get;set;}
        public string Code {get;set;}
        public string State {get;set;}
        public string City {get;set;}
        public string Address {get;set;}
        public double Latitude {get;set;} // double required for precision
        public double Longitude {get;set;}
    }
}