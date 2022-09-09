using System;
using System.Collections.Generic;

namespace DroneDelivery.App.Dominio
{
    public class Battery 
    {
        public int Id {get;set;}
        public string Code {get;set;}
        public DateTime ExpirationDate {get;set;}
        public DateTime OperationDate {get;set;}
        public float RemainingFlightTime {get;set;}
        public float CyclesCount {get;set;}
        public DateTime TimeTofullCharge {get;set;}
        private Battery (int Id)
        {
            this.Id = id;
        }

        public Battery ()
        {
            
        }
    }
}