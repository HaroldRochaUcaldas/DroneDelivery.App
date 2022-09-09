using System;
using System.Collections.Generic;

namespace DroneDelivery.App.Dominio
{
    public class ForbidenFlightZone
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public string Code {get;set;}
        public List<Location> ForbidenPoints {get;set;}
        
        private ForbidenFlightZone (int id)
        {
            this.Id = id;
        } 

        public ForbidenFlightZone(string nombre, string codigo, 
                             List<Location> puntos)
        {
            this.Name = nombre;
            this.Code = codigo;
            this.ForbidenPoints = puntos;
        }
    }
}
