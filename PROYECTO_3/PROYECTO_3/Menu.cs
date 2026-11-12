using PROYECTO_3;
using System;

public class Menu
{
    private Pila pilaLlamadas = new Pila();

    public void MostrarMenu()
    {
        int opcion = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("=== SIMULADOR DE LLAMADAS TELEFÓNICAS (PILA) ===");
            Console.WriteLine("1. Registrar llamada");
            Console.WriteLine("2. Atender llamada");
            Console.WriteLine("3. Finalizar llamada");
            Console.WriteLine("4. Mostrar llamadas activas");
            Console.WriteLine("5. Recuperar última llamada");
            Console.WriteLine("6. Buscar llamada");
            Console.WriteLine("7. Eliminar llamada");
            Console.WriteLine("8. Salir");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Registrar();
                        break;
                    case 2:
                    case 3:
                        AtenderOFinalizar();
                        break;
                    case 4:
                        pilaLlamadas.MostrarLlamadas();
                        break;
                    case 5:
                        RecuperarUltima();
                        break;
                    case 6:
                        Buscar();
                        break;
                    case 7:
                        Eliminar();
                        break;
                    case 8:
                        Console.WriteLine("\nSaliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("\nOpción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nPor favor, ingrese un número válido.");
            }

            if (opcion != 8)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 8);
    }

    private void Registrar()
    {
        Console.Clear();
        Console.WriteLine("--- REGISTRAR LLAMADA ---");
        Console.Write("Ingrese número de teléfono: ");
        string tel = Console.ReadLine();
        Console.Write("Ingrese nombre de la persona: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese motivo de la llamada: ");
        string motivo = Console.ReadLine();

        Llamada nueva = new Llamada(tel, nombre, motivo);
        pilaLlamadas.RegistrarLlamada(nueva);
    }

    private void AtenderOFinalizar()
    {
        Console.Clear();
        Console.WriteLine("--- ATENDER / FINALIZAR LLAMADA ---");
        Llamada atendida = pilaLlamadas.AtenderLlamada();
        if (atendida != null)
        {
            Console.WriteLine($"\nSe atendió/finalizó la siguiente llamada:\n{atendida}");
        }
        else
        {
            Console.WriteLine("\nNo hay llamadas activas.");
        }
    }

    private void RecuperarUltima()
    {
        Console.Clear();
        Console.WriteLine("--- RECUPERAR ÚLTIMA LLAMADA ---");
        Llamada ultima = pilaLlamadas.RecuperarUltimaLlamada();
        if (ultima != null)
        {
            Console.WriteLine($"\nÚltima llamada (Tope de la Pila):\n{ultima}");
        }
        else
        {
            Console.WriteLine("\nNo hay llamadas en la pila.");
        }
    }

    private void Buscar()
    {
        Console.Clear();
        Console.WriteLine("--- BUSCAR LLAMADA ---");
        Console.Write("Ingrese el número de teléfono a buscar: ");
        string tel = Console.ReadLine();

        bool encontrada = pilaLlamadas.BuscarLlamada(tel);
        if (encontrada)
        {
            Console.WriteLine($"\n¡La llamada con número {tel} fue encontrada!");
        }
        else
        {
            Console.WriteLine($"\nNo se encontró ninguna llamada con el número {tel}.");
        }
    }

    private void Eliminar()
    {
        Console.Clear();
        Console.WriteLine("--- ELIMINAR LLAMADA ---");
        Console.Write("Ingrese el número de teléfono de la llamada a eliminar: ");
        string tel = Console.ReadLine();

        bool eliminada = pilaLlamadas.EliminarLlamada(tel);
        if (eliminada)
        {
            Console.WriteLine($"\nLa llamada con número {tel} ha sido eliminada.");
        }
        else
        {
            Console.WriteLine($"\nNo se pudo encontrar o eliminar la llamada.");
        }
    }
}