using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_2
{
    internal class Programm
    {
        static Cola espera = new Cola();
        static void Main()
        {
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("====RESTAURANTE====");
                Console.WriteLine("1.Agregar cliente");
                Console.WriteLine("2.Asignar mesa");
                Console.WriteLine("3.Mostrar espera");
                Console.WriteLine("0.Salir");
                Console.Write("Opcion: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Agregar();
                        break;

                    case 2:
                        AsignarMesa();
                        break;

                        case 3
                        espera.Mostrar();
                        Console.ReadKey();
                        break;

                }
            } while (opcion != 0);
        }

        static void Agregar()
        {
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Numero de personas: ");
            int personas = int.Parse(Console.ReadLine());

            espera.Encolar(
                new Cliente(nombre, personas));

            Console.Write("Cliente agregado");
            Console.ReadKey();
        }

        static void AsignarMesa()
        {
            Cliente cliente = espera.Desencolar();

            if (cliente == null)
                Console.WriteLine("No hay clientes.");
            else
                Console.WriteLine(
                    $"Mesa asignada a {cliente}");

            Console.ReadKey();
        }
    }
}
