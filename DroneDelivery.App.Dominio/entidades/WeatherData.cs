using System;

namespace DroneDelivery.App.Dominio
{
    public class WeatherData
    {
        public int Id{get;set;}
        public string DataType {get;set;}
        public DateTime TimeStamp {get;set;}
        public float Measurement {get;set;}
        public string Unit {get;set;}

        private WeatherData(int id)
        {
            this.Id = id;
        }
    }
}

