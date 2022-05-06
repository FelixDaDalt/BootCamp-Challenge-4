using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_4
{
    public class Persona
    {
        private int edad;
        private int dni;
        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Dni { get => dni; set => dni = value; }

        public Persona()
        {
           
        }


        public virtual void Mostrar()
        {
            Console.WriteLine($"Nombre: {this.nombre}");
            Console.WriteLine($"Edad: {this.Edad}");
            Console.WriteLine($"DNI: {this.Dni}\n");
        }

        public bool esMayor()
        {
            if (this.edad < 18)
                return false;
            else
                return true;        
        }
    }
}
