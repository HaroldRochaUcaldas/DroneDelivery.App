using system;
using System.Collections.Generic;

namespace DroneDelivery.App.Dominio
{
    public class PostOffice
    {
        public int Id {get;set;}
        public int Name {get;set;}
        public string TimeOpen {get;set;}
        public string TimeClose {get;set;}
        public int StoredPackages {get;set;}
        public int AcceptedPackages {get;set;}
        public int TransferedPackages {get;set;}
        public Operator PostOperator {get;set;}
        public Location OfficeLocation {get;set;}
        public List<Operator> Employees {get;set;}

        public PostOffice (int id)
        {
            this.Id = id;
        }




    }
}
