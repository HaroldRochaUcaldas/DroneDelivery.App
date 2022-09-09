using System;
using System.Collections.Generic;

namespace DroneDelivery.App.Dominio
{
    public class City
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Departamento {get;set;}
        public string Codigo {get;set;}
        public ICollection<ZonaProhibida> ZPV {get;set;}
        public List<Ubicacion> Limites {get;set;}

        public ICollection<ZonaReparto> Zonas {get;set;}
        
        private Municipio (int id)
        {
            this.Id = id;
        }

        public Municipio (string nombre, string departamento, string codigo)
        {
            this.Nombre = nombre;
            this.Departamento = departamento;
            this.Codigo = codigo;

        }

        public void ModificarLimites (List<Ubicacion> limites)
        {
            if (limites.Count >= 4) 
            {
                this.Limites = limites;                
            } else
            {
                throw new ArgumentException(String.Format(
                    "Se deben ingresar al menos 4 puntos limitrofes." 
                    + "Fueron ingresados solo {0} puntos", limites.Count ));
            }
        }

        public void AgregarLimites (List<Ubicacion> limites)
        {
            foreach (Ubicacion punto in limites) 
            {
                this.Limites.Add(punto);
            }
        }

    }
}