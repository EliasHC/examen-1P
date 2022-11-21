using System;

    public class Barco: Pago
    {
        public string nombre {get; set;}
         public string Tipo {get; set;}
        public int CapaPasajeros {get; set;}
        public int CapaCarga {get; set;}
       
       public Barco (string nombre, string Tipo, int CapaPasajeros, int CapaCarga)
       {
             this.nombre=nombre;
             this.Tipo=Tipo;
             this.CapaPasajeros=CapaPasajeros;
             this.CapaCarga=CapaCarga;

       }
    }  

         

    