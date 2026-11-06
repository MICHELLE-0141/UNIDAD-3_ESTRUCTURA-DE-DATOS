using System;
using System.Collections.Generic;
using System.Text;

namespace PROYECTO_1
{
    internal class Menu
    {
        static Cola paciente = new Cola();

        static void Main(string[]args)
        {
            int Opcion;
            do
            {
                Console.Clear();

                Console.WriteLine("===CLINICA====");
                Console.WriteLine("1.Registar paciente"):
                Console.WriteLine("2.Antender paciente");
                Console.WriteLine("3.Mostrar pacientes");
                Console.WriteLine("0.Salir");
                Console.WriteLine("Opcion");

                Opcion = int.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case 1:
                        Registar();
                        break;

                    case 2:
                        Atender();
                        break;

                    case 3:
                        paciente.Mostrar();
                        Console.ReadKey();
                        break;

                }


            } while (Opcion!= 0);
        }

        static void Registrar()
        {
            Console.Write("Expedinte:");
            int expedinete = int.Parse(Console.ReadLine());

            Console.Write("Nombre: "),
            string nombre = Console.ReadLine();

            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Prioridad: ");
            int prioridad = int.Parse(Console.ReadLine());

            Paciente paciente =
                new Paciente(expediente, nombre, edad, prioridad);

            paciente.Encolar(paciente);

            Console.WriteLine("Paciente registrado.");
            Console.ReadKey();

        }

        static void Atender()
        {
            Paciente paciente = pacientes.Desencolar();

            if (paciente == null)
                Console.WriteLine("No hay paciente.");
            else
                Console.WriteLine("Atendiendo:");

            if (paciente != null)
                Console.WriteLine(paciente);
            Console.ReadKey();

        }
    }
}
