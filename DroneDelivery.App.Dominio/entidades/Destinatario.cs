using System;

namespace DroneDelivery.App.Dominio
{
    public class Destinatario : Cliente 
    {
        public Ubicacion PuntoEntrega{get;set;}
    }
}