using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_4
{
    internal class Cuenta : Persona
    {
        private Persona titular;
        private double cantidad;

        protected Persona Titular { get => titular; set => titular = new Persona(); }
        protected double Cantidad { get => cantidad; set => cantidad = value; }

        public Cuenta()
        {
            this.titular = new Persona();
            this.cantidad = 0;
        }

        public Cuenta(Persona tit, double cantidad=0)
        {
            this.titular = tit;
            this.cantidad = cantidad;
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Titular: {this.titular.Nombre}");
            Console.WriteLine($"Cantidad: {this.Cantidad}\n");
        }
    }
}
