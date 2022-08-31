using System;

namespace DroneDelivery.App.Dominio
{
    public class Cliente : Persona 
    {
        public int NumeroEnviosRecibidos{set;get;}
        public int NumeroEnviosRealizados{set;get;}
        public int CalificacionPromedioRecibido{set;get;}
        public int CalificacionPromedioRealizado{set;get;}

        //Class Methods
        public void calificarEnvio(Envio envio, 
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
        }

    }
}