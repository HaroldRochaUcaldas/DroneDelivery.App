using System;

namespace DroneDelivery.App.Dominio
{
    public class Ubicacion 
    {
        public string Departamento{get;set;}
        public string Municipio{get;set;}
        public string Direccion{get;set;}
        public double Latitud{get;set;} // double required for precision
        public double Longitud{get;set;}

    }
}