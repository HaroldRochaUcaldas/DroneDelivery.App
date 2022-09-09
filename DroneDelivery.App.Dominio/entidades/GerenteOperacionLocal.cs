using System;
using DroneDelivery.App.Dominio;

namespace DroneDelivery.App.Dominio
{
    public class GerenteOperacion : Persona
    {
        public string telOficina {get;set;}
        public string User {get;set;}
        public string Password {get;set;}

        public GerenteOperacion (string nombre, string edad, string cedula,
            string celular, string email) : base (nombre, edad, cedula, celular,
            email)
        {
            
        }
        
        public void ContratarEncargado (ZonaReparto zona, Persona empleado)
        {
            zona.Empleados.Add(empleado);
        }

        public void ContratarOperador (Sucursal sucursal, Persona empleado)
        {
            sucursal.Empleados.Add(empleado);
        }
    }
}