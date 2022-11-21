using System;

    public class Capitan: Pago
    {
        public int Cedula {get; set;}
        public string sexo {get; set;}
        public int edad {get; set;}
        public int telefono {get; set;}
        public string tiempoEmpresa {get; set;}
        public int sueldoBase {get; set;}
        public int bono {get; set;}
        public int sueldoTotal {get; set;}

        public Capitan (int Cedula, string sexo, int edad, int telefono, string tiempoEmpresa, int sueldoBase, int bono,int sueldoTotal)
        {
            this.Cedula=Cedula;
            this.sexo=sexo;
            this.edad=edad;
            this.telefono=telefono;
            this.tiempoEmpresa=tiempoEmpresa;
            this.sueldoBase=sueldoBase;
            this.bono=bono;
            this.sueldoTotal=sueldoTotal;

        }

        

    }
      