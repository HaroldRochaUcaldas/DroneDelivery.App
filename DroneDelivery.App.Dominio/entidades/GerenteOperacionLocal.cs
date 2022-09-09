using System;
using DroneDelivery.App.Dominio;

namespace DroneDelivery.App.Dominio
{
    public class LocalManager : Person
    {
        public string telOficina {get;set;}
        public string User {get;set;}
        public string Password {get;set;}

        public LocalManager (string nombre, string edad, string cedula,
            string celular, string email) : base (nombre, edad, cedula, celular,
            email)
        {
            
        }
        
        public void CreateDeliver (Warehouse deliveryCenter,
          PostOfficeCarrier carrier)
        {
            deliveryCente.Employees.Add(carrier);
        }

        public void CreateOperador (PostOffice postOffice, 
         PostOfficeClerk clerk)
        {
            postOffice.Employees.Add(empleado);
        }
    }
}