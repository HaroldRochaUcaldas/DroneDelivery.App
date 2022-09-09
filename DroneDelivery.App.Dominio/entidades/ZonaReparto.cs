using System;
using System.Collections.Generic;

namespace DroneDelivery.App.Dominio
{
    public class DeliveryZone
    {
        public int Id {get;set;}
        public float Radius {get;set;}
        public int Deliveries {get;set;}
        public int UnassignedDeliveries {get;set;}
        public int DeliveriesFlighting {get;set;}
        public int Complaints {get;set;}
        public int Chiefs {get;set;}
        public int AvailableChiefs {get;set;}
        public int Clients {get;set;}

        public Location CentralLocation {get;set;}
        public List<PostOffice> Offices {get;set;}
        public OperationNode MainNode {get;set;}
        
        private DeliveryZone (int id)
        {
            this.Id = id;
        } 

        public DeliveryZone (float radius, Location addressLocation)
        {
            this.Radius = radius;
            this.CentralLocation = addressLocation;
        }

        public static bool checkDistances(Location locA, Location locB, float radius)
        {
            double x = Math.Pow(locA.Latitude - locB.Latitude, 2);
            double y = Math.Pow(locA.Longitude - locB.Longitude, 2);
            double distance = Math.Pow (x + y, 0.5d);

            if (distance <= radius)
            {
                return true;
            } else 
            {
                return false;
            }


        }


    }
}