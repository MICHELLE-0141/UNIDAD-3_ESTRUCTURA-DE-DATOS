using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PROYECTO_3
{
    public class Pila
    {
        private Nodo tope;

        public Pila()
        {
            tope = null;
        }

        public bool EstaVacia()
        {
            return tope == null;
        }

        //registar llamada
        public void RegistrarLlamada(Llamada llamada)
        {
            Nodo nuevo = new Nodo(llamada);
            nuevo.Siguiente = tope;
            tope = nuevo;
            Console.WriteLine("\n!Llamada regiatrada con exito! ");
        }

        //atender Finalizar Llamada 
        public Llamada AtenderLlamada()
        {
            if (EstaVacia())
            {
                return null;
            }

            Llamada atendidad = tope.LlamadaDatos;
            tope = tope.Siguente;
            return atendidad;

        }


        //Mostar llamamadas activas 
        public void MostrarLlamadas()
        {
            if (EstaVacia())
            {
                Console.WriteLine("\n--- Pila de llamadas activas ---");
                int i = 1;
                while (actual != null)
                {
                    Console.WriteLine($"{i}. {actual.LlamadaDatos}");
                    actual = actual.Siguiente;
                    i++;
                }
            }

            //Recuperar ultima llamada
            public Llamada RecuperarUltimaLlamada()
            {
            if (EstaVacia())
            {
                return null;
            }
            return tope.LlamadaDatos;
            }
        //Buscar llamada por nuemro de telefono
        public bool BuscarLlamada(string numero)
        {
            Nodo actual = tope;
            while (actual != null)
            {
                if(actual.LlamadaDatos.NumeroTelefono == numero)
                {
                    return true;
                }
                actual = actual.Siguiente;
            }
            return false;
        }

        //Eliminar llamada especifica de la pila
        public bool EliminarLlamad(string numero)
        {
            if (EstaVacia()) return false;

            //si esta en el tope
            if (tope.LlamadaDatos.NumeroTelefono == numero)
            {
                tope = tope.Siguiente;
                return true;
            }

            Nodo actual = tope;
            while ( actual.Siguiente.LlamadaDatos.NumeroTelefono == numero)
            {
                actual.Sguiente = actaual.Siguiente.Siguiente;
                return true;
            }
            actual = actual.Siguiente;
        }
         return false;
    }
}
