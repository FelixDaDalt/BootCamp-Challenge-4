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
            Ejercicio2();
            Console.ReadKey();
        }

        static void Ejercicio2()
        {
            List<Persona> clientes = new List<Persona>();
            List<Cuenta> cuentas = new List<Cuenta>();
            ConsoleKey tecla;
            
            do
            {
                Console.Clear();
                Console.Write(" 1) Cargar Clientes, 2) Crear cuenta\n 3) Mostrar Clientes, 4) Mostrar Cuentas\n\n Esc) Salir\n\n Persione su opcion: ");
                tecla = Console.ReadKey().Key;
                Console.Clear();
                switch (tecla)
                {
                    case ConsoleKey.D1:
                        CargarClientes(clientes);
                        break;
                    case ConsoleKey.D2:
                        CrearCuenta(cuentas, clientes);
                        break;
                    case ConsoleKey.D3:
                        if (clientes.Count > 0)
                        {
                            foreach (Persona value in clientes)
                            {
                                   value.Mostrar();
                            }
                        }
                        else
                            Console.WriteLine("No hay clientes");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D4:
                        if (cuentas.Count > 0)
                        {
                            foreach (Cuenta value in cuentas)
                            {
                                value.Mostrar();
                            }
                        }
                        else
                            Console.WriteLine("No hay cuentas");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta");
                        Console.ReadKey();
                        break;
                }
            } while (tecla != ConsoleKey.Escape);
           
            


        }

        static void CargarClientes(List<Persona> persona)
        {
           
            do
            {
                Console.Clear();
                Console.WriteLine("CREANDO CUENTA NUEVA:::::::");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());
                Console.Write("Dni: ");
                int dni = Convert.ToInt32(Console.ReadLine());

                persona.Add(new Persona { Nombre = nombre, Edad = edad, Dni = dni });

                Console.WriteLine("\nPresionar ESC si desea salir");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        static void CrearCuenta(List<Cuenta> cuenta, List<Persona> clien)
        {
            Console.Clear();
            if(clien.Count > 0)
            { 
                Console.WriteLine("Clientes::::: ");
                for(int x=0;x<clien.Count;x++)
                {
                    Console.WriteLine($"{x} - {clien[x].Nombre}");
                }
                int num = 0;
                do {
                    Console.Write("Ingrese el numero de cliente: ");
                } while (!Int32.TryParse(Console.ReadLine(), out num) || num > clien.Count || num < 0);
                cuenta.Add(new Cuenta(clien[num]));
                Console.WriteLine($"Cuenta creada al cliente {clien[num].Nombre}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No hay Clientes, cargaremos el primero!");
                Console.ReadKey();
                CargarClientes(clien);
            }
           

        }
    }
}
