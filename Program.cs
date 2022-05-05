using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp_Challenge_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
            Console.ReadKey();
        }

        static void Ejercicio1()
        {
            Persona[] per = new Persona[3];
            for (int x = 0; x < per.Length; x++)
            {
                Console.WriteLine("Nombre: ");
                per[x] = new Persona();
                per[x].Name = Console.ReadLine();
            }
            for (int x = 0; x < per.Length; x++)
            {
                Console.WriteLine(per[x].ToString());
            }
            
        }
    }
}
