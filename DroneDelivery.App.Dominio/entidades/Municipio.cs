using System;
using System.Collections.Generic;

namespace DroneDelivery.App.Dominio
{
    public class City
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public string State {get;set;}
        public string Code {get;set;}
        public ICollection<ForbidenFlightZone> FFZ {get;set;}
        public List<Location> CityLimits {get;set;}

        public ICollection<DeliveryZone> Zones {get;set;}
        
        private Municipio (int id)
        {
            this.Id = id;
        }

        public Municipio (string name, string state, string code)
        {
            this.Name = name;
            this.State = state;
            this.Code = code;

        }

        public void ModificarLimites (List<Location> limites)
        {
            if (limites.Count >= 4) 
            {
                this.CityLimits = limites;                
            } else
            {
                throw new ArgumentException(String.Format(
                    "Se deben ingresar al menos 4 puntos limitrofes." 
                    + "Fueron ingresados solo {0} puntos", limites.Count ));
            }
        }

        public void AgregarLimites (List<Location> limites)
        {
            foreach (Location punto in limites) 
            {
                this.CityLimits.Add(punto);
            }
        }

    }
}