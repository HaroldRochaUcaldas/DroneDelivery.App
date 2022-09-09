using System;

namespace DroneDelivery.App.Dominio
{

public class Person
    {

        public string Name {set;get;}
        public string Age {set;get;}
        public string PIN {set;get;} // Personal Identification Number
        public string Phone {set;get;}
        public string Email {set;get;}



        public Person (string name, string age, string pin,
                        string phone, string email)
        {
            this.Name = nombre;
            this.Age = age;
            this.PIN = pin;
            this.Phone = phone;
            this.Email = email;
        }

    }
}
