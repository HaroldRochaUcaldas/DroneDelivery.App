using System;
using System.Collections.Generic;

namespace DroneDelivery.App.Dominio
{
    public class WeatherStation
    {
        public int Id{get;set;}
        public List<WeatherData> Data {get;set;}
        public string Status {get;set;}

        private WeatherStation(int id)
        {
            this.Id = id;
        }
    }
}

