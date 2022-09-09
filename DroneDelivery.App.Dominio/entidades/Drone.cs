using System;

namespace Drones.App.Dominio
{
    public class Drone 
    {
        public int Id {get;set;}
        public int Code {get;set;}
        public int StandByTime {get;set;}
        public string Status {get;set;}
        public DateTime timeDeparture {get;set;}
        public DateTime timeArrival {get;set;}
        public double CumulativeFlightTime {get;set;}
        public double DeliveryTime {get;set;}
        public double FlightTime {get;set;}
        public int BatteryCount {get;set;}
        public float FlightAltitude {get;set;}
        public float FlightSpeed {get;set;}
        public float MaxSpeed {get;set;}
        public float PackageCons {get;set;}
        public float WeatherCons {get;set;}
        public float Temp {get;set;}
        public float MaxTemp {get;set;}
        public float Tcs {get;set;}
        public float TempCons {get;set;}
        public float Capacity {get;set;}
        public double Latitude {get;set;}
        public double Longitude {get;set;}

        public string Model {get;set;}

        public List<Battery> Batteries {get;set;}

        //Constructor
        private Drone (int id)
        {
            this.Id = id;
        }

        public Drone(string model) 
        { 
            this.Status = "Waiting at base"; 
            this.Model = model;   
            this.BatteryCount = 3;
            this.FlightTime = 45 * 60.0F;  
            this.CumulativeFlightTime = 0F;     
            switch (model)
            {
                case "deliveryboy":
                    this.Capacity = 3.0F;
                    this.PackageCons = 2.0F;
                    this.WeatherCons = 0.5F;
                    this.MaxTemp = 50.0F;
                    this.Tcs = 95F;
                    this.MaxSpeed = 35.0F;
                    break;
                
                case "cargoboy":
                    this.Capacity = 12.0F;
                    this.PackageCons = 1.0F;
                    this.WeatherCons = 0.3F;
                    this.MaxTemp = 60.0F;
                    this.Tcs = 80F;
                    this.MaxSpeed = 40.0F;
                    break;                
            }     
                     
        }
    }
}