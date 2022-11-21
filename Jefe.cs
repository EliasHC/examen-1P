using System;

    public class Jefe:Pago
    {
        public int Cedula {get; set;}
        public string sexo {get; set;}
        public int edad {get; set;}
        public int telefono {get; set;}
        public string tiempoEmpresa {get; set;}
        public int sueldoBase {get; set;}
        public int bonoPescado {get; set;}
        public int bonoMariscos {get; set;}
        public int sueldoTotal {get; set;}

        public Jefe (int Cedula, string sexo, int edad, int telefono, string tiempoEmpresa, int sueldoBase, int bonoPescado, int bonoMariscos, int sueldoTotal)
        {
            this.Cedula=Cedula;
            this.sexo=sexo;
            this.edad=edad;
            this.telefono=telefono;
            this.tiempoEmpresa=tiempoEmpresa;
            this.sueldoBase=sueldoBase;
            this.bonoPescado=bonoPescado;
            this.bonoMariscos=bonoMariscos;
            this.sueldoTotal=sueldoTotal;

        }
    }