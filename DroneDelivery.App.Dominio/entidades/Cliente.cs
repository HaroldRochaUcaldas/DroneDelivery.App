using System;

namespace DroneDelivery.App.Dominio
{
    public class ShippingClient : Person
    {
        public int Id {get;set;}
        public int ReceivedShippments{get;set;}
        public int SentShipments{get;set;}
        public float AverageRatingReceived{get;set;}
        public float AverageRatingReceived{get;set;}
        public Location ClientLocation{get;set;}
        public string ClientAddress{get;set;} 
        
        private ShippingClient (int id)
        {
            this.Id = id;
        }

        public ShippingClient (string name, string age, string pin,
         string phone, string email) : base (name , age, pin, phone, email)
         {
            
         }

        //Class Methods
        /*
        public void RateService(E envio, 
                                   int calificacion,
                                   string tipoEnvio) 
        {
            envio.calificacion = calificacion;
            switch (tipoEnvio)
            {
                case "recibido" :
                this.CalificacionPromedioRecibido =
                (this.CalificacionPromedioRecibido + calificacion)
                / this.NumeroEnviosRecibidos;
                break;

                case "realizado" :
                this.CalificacionPromedioRealizado =
                (this.CalificacionPromedioRealizado + calificacion) 
                / this.NumeroEnviosRealizados;
                break;

                default:
                break;
            
            }
        }*/

    }
}